package repositories

import (
	"log"
	// "fmt"
	// "github.com/davecgh/go-spew/spew"

	"MyApp/models"
)

type UserRepository struct {}

func NewUserRepository() *UserRepository {
	repository := &UserRepository{}
	return repository
}

// func ( r *UserRepository ) getAll() []models.User {
func ( r *UserRepository ) GetAll() ([]models.User ) {
	users := []models.User{}
	err := DB.Select( &users, "SELECT * FROM users" )
	if err != nil {
		log.Fatalf( "Failed to get users: %v", err )
	}

	return users
}