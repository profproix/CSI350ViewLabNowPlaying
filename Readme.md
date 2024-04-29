# Controllers and Routes Lab
## Objectives: Students will be able to
- Review MVC Pattern
- Build Controller Actions 
- Create Custome routes 

## Pre-configuration 
1. Update the connection string in appsetting.json to your local server 
2. Run update-database. The migrations should already be created.
3. Verify the Database is set up and that you can run the application.  

## Controller Review 
The following should be a review from last quarter. As such, the instructions will be a bit more vague. 
Complete the Movie Controller. Since the Model and Views for this controller are already in place, you shouldn't need to make changes outside of the MoviesController File for this section. Test each action as you complete it.
1. Create an Index Action that gets a list of movies from the Database and renders them to the Index View.
2. Create a Detail Action that receives an optional id parameter. It should find a movie by that ID and render it in the Detail view. If the Movie is not found, return NotFound();
3. Create an action that renders the Create View
4. Create a POST action that recives attirbutes for a Movie. If the Movie is Valid, it should save the Movie to the Database and redirect to the index page to render the Create view again. 
5. Create an Action that Renders the Edit View.
6. Create a Post-Edit Action that receives attributes for a Movie. It should find a Movie by its ID, update it in the Database, and redirect back to the index page. If the Movie is not found, return NotFound(); if the Movie is not valid, render the Edit view once more. 
7. Create an Action that Renders the Delete confirmation page. 
8. Create a Post with the Action name Delete called DeleteConfirmed that receives an ID. It should find the Movie by its ID, delete it from the Database, and render the Index view. 

## Custom Routes 
Create a custom route that includes the movie's rating. 
1. in Program.cs include this line above the app.MapControllerRoute(...) 
app.MapControllerRoute(name: "rating",
                pattern: "movie/{id:int}/{rating?}",
                defaults: new { controller = "rating", action = "Details" });
    Note: The id:int is a route constraint
2. In the Movies controller above the Details action, add  [route ("movie/{id:int}/{rating}")]
3. In the Index view, update the anchor tag to include this helper asp-route-beds="@item.rating"
4. Run your code and confirm the custom route is working. You should see something like `Movie/Details/3/PG`

## Extra Credit (5pt)
Auth Review:
Add Authorization restrictions to the Movie controller. Only someone with the Admin role should be able to access the Movie Create, Edit, and Delete functionality.

And/Or Create 2 more custom routes.

