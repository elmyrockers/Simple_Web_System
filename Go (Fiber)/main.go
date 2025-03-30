package main

import (
	// "github.com/davecgh/go-spew/spew"
	"github.com/gofiber/fiber/v2"
	"github.com/gofiber/template/jet/v2"

	"MyApp/routes"
	"log"
)


func main() {
	// Create Fiber app
		engine := jet.New( "./views", ".jet" )
		app := fiber.New(fiber.Config{
			Views: engine,
		})
	
	// Routes
		routes.SetupWebRoute( app )

	// Run HTTP Server
		app.Listen( ":3000" )
		var err error
		if err != nil {
			log.Fatalf( "Error starting server: %v", err )
		}
}