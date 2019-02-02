# CookBookAPI
Within this repo contains the database which stores the recipe information that is called upon by the front end web app. Users can access it through search requests and creating references to the API within their profile, but only admins can make changes to the API.

## Database Schema
![dbschema](https://github.com/mbgoseco/CookBookAPI/blob/master/assets/APIDB_SCHEMA.png)

Recipe
- ID (Primary Key)
- Name - Name of each recipe

Ingredients
- RecipeID (Composite Key) - The recipe that this quantity of ingredient is associated to
- IngredientsID (Composite Key) - The ingredient that belongs in a given recipe and its quantity
- Quantity - Amount of each ingredient in a recipe

RecipeIngredients
- ID (Primary Key)
- Name - Name of each ingredient

Instructions
- RecipeID (Composite Key)
- StepNumber (Composite Key) - The number of steps associated with each of their instructions in a given recipe
- Action - The instructions of a specific step in a given recipe
