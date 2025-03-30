package models

type User struct {
	ID     int      `db:"id"`
	Name   string   `db:"name"`
	Email  string   `db:"email"`
	Created  string `db:"created"`
	Modified string `db:"modified"`
}