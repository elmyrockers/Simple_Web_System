// config/init.go
package config

import (
	"fmt"
	"os"

	"github.com/pelletier/go-toml/v2"
)

type Config struct {
	Title    string   `toml:"title"`
	Database Database `toml:"database"`
	Server   Server   `toml:"server"`
}

type Database struct {
	Driver string `toml:"driver"`
	DSN    string `toml:"dsn"`
}

type Server struct {
	Port int    `toml:"port"`
	Host string `toml:"host"`
}

var AppConfig Config

func init() {
	configFile, err := os.ReadFile( "config/AppConfig.toml" )
	if err != nil {
		fmt.Println( "Error reading config file:", err )
		return
	}

	err = toml.Unmarshal( configFile, &AppConfig )
	if err != nil {
		fmt.Println( "Error unmarshaling config file:", err )
		return
	}
}