# Security Lab: Identity Framework Authorization and Authentication
## Objectives: Students will be able to
- Recall the difference between Authentication and Authorization 
- Configure a web application to use the Identity framework. 
- Connect the current DbContext to the Scaffolded Identity files. 

## Pre-configuration 
1 . Update the connection string in appsetting.json to your local server 
2. Run update-database. The migrations should already be created.
3. Verify the Database is set up and that you can run the application.  

## Identity Configuration 
1. Install Microsoft.AspNetCore.Identity.EntityFrameworkCore
2. Double click the Project name 'NowPlaying' This will open the project file. NowPlaying.csproj In tiemGroupo add `<FrameworkReference Include="Microsoft.AspNetCore.app" />`
[!Adding Frameworks](AddingFrameworks.jpg)

3. In ApplicationDBContext.cs, add `IdentityDbContext<IdentityUser>` as an inherited class to ApplicationDbContext
[!Changing Db Context](applicationdbcontext.png)
4. Scaffoled Identity by right-clicking the project and selecting Add -> New Scaffoled Item. Select Identity and Click add
5. Set the DbContext to ApplicationDBContext (which you should see as an option in the drop-down) and check the Override all files box. Click Add.
6. In ApplicationDBContext to the top of OnModelCreating method add  `base.OnModelCreating(modelBuilder);` 
7. In Program.cs Add app.UseAuthentication(); above app.UseAuthorization();
8. In Program.cs Add app.MapRazorPages(); above app.MapControllerRoute(..)
9. In Program.cs Add builder.Services.AddRazorPages(); under builder.Services.AddDefaultIdentity
10. in _Layout.cshtml add     <partial name="_LoginPartial" /> to the navigation bar. 
Note: To remove the bullets, add the class of `nav` to the ul in the _LoginPartial.cshtml
11. Run the Program and test your code by Registering a User

## Extra Credit (5pt)
Add an Admin Role and restrict the Movie Create, Edit, and Delete functionality. 
Only the Admin should be able to see the Create Movie, Edit, and Delete buttons
Only the Admin should be able to visit the Create, Edit, and Delete pages. 
[Tutorial for adding roles](https://www.youtube.com/watch?v=Y6DCP-yH-9Q&ab_channel=tutorialsEU-C%23)

### Citations 
Movies
Wikipedia contributors. (2024c, April 19). Alien (film). Wikipedia. https://en.wikipedia.org/wiki/Alien_(film)
Wikipedia contributors. (2024d, April 21). Star Trek III: The Search for Spock. Wikipedia. https://en.wikipedia.org/wiki/Star_Trek_III:_The_Search_for_Spock
Wikipedia contributors. (2024d, April 19). Back to the future. Wikipedia. https://en.wikipedia.org/wiki/Back_to_the_Future
