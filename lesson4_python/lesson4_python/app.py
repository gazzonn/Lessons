from flask import Flask, request, render_template, redirect, url_for, flash
import sqlite3
import secrets

app = Flask(__name__)
app.secret_key = secrets.token_urlsafe(16)

def get_db_connection():
    conn = sqlite3.connect('books.db')
    conn.row_factory = sqlite3.Row
    return conn

@app.route('/')
def index():
    conn = get_db_connection()
    books = conn.execute('SELECT * FROM books').fetchall()
    conn.close()
    return render_template('index.html', books=books)

@app.route('/add', methods=['GET', 'POST'])
def add():
    if request.method == 'POST':
        title = request.form.get('title')
        author = request.form.get('author')
        try:
            year = int(request.form.get('year'))
        except ValueError:
            flash("Year must be integer!")
            return render_template('add.html')
        
        if not title or not author or not year:
            flash("All fields must be filled in!")
            return render_template('add.html')
        
        conn = get_db_connection()
        conn.execute('INSERT INTO books (title, author, year) VALUES (?, ?, ?)', (title, author, year))
        conn.commit()
        conn.close()
        
        return redirect(url_for('index'))
    
    return render_template('add.html')

@app.route('/edit/<int:id>', methods=['GET', 'POST'])
def edit(id):
    conn = get_db_connection()
    book = conn.execute('SELECT * FROM books WHERE id = ?', (id,)).fetchone()
    conn.close()
    
    if request.method == 'POST':
        title = request.form.get('title')
        author = request.form.get('author')
        try:
            year = int(request.form.get('year'))
        except ValueError:
            flash("Year must be integer!")
            return render_template('edit.html', book=book)
        
        if not title or not author or not year:
            flash("All fields must be filled in!")
            return render_template('edit.html', book=book)
        
        conn = get_db_connection()
        conn.execute('UPDATE books SET title = ?, author = ?, year = ? WHERE id = ?', (title, author, year, id))
        conn.commit()
        conn.close()
        
        return redirect(url_for('index'))
    
    return render_template('edit.html', book=book)

@app.route('/delete/<int:id>')
def delete(id):
    conn = get_db_connection()
    conn.execute('DELETE FROM books WHERE id = ?', (id,))
    conn.commit()
    conn.close()
    
    return redirect(url_for('index'))

if __name__ == '__main__':
    app.run(debug=True)
