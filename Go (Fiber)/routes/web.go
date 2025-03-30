package routes

import (
	"github.com/gofiber/fiber/v2"
	
	"MyApp/controllers"
)



func SetupWebRoute( app *fiber.App ) {
	usersController := controllers.NewUsersController()
		app.Get( "/", usersController.Index )
		
	app.Static( "/", "./public" )
}