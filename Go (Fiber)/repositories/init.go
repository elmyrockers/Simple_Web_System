package repositories

import (
	"log"
	"github.com/jmoiron/sqlx"
	_ "github.com/go-sql-driver/mysql"

	"MyApp/config"
)

var DB *sqlx.DB
func connectDB() {
		var err error
		DSN := config.AppConfig.Database.DSN
		DRIVER := config.AppConfig.Database.Driver
		DB, err = sqlx.Connect( DRIVER, DSN )
		if err != nil {
			log.Fatalf( "Failed to connect to database: %v", err )
		}
		log.Println( "Database connection established" )
}

func init() {
	log.Println( "init function is called!" )
	connectDB();
}