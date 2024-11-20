import sqlite3

# Establish connection to database
conn = sqlite3.connect('books.db')
cursor = conn.cursor()

# Create the books table if it doesn't exist already
cursor.execute('''
CREATE TABLE IF NOT EXISTS books (
    id INTEGER PRIMARY KEY,
    title TEXT NOT NULL,
    author TEXT NOT NULL,
    year INTEGER NOT NULL
)
''')

# Save changes and close the connection
conn.commit()
conn.close()