package controllers

import (
	// "fmt"
	"github.com/davecgh/go-spew/spew"
	"github.com/gofiber/fiber/v2"

	"MyApp/repositories"
)

// Users Controller
	type UsersController struct {
		repositories.UserRepository
	}

// Constructor
	func NewUsersController() *UsersController {
		controller := &UsersController{}
		return controller
	}

// Index
	func (uc *UsersController) Index(context *fiber.Ctx) error {
		// Retrieve data from users table
			users := uc.UserRepository.GetAll()
			spew.Dump( users )

		// Render view
			data := fiber.Map{
				"users": users,
			}
			return context.Render( "users/index", data )
	}