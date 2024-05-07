# Controllers and Routes Lab
## Objectives: Students will be able to
- Review Views
- Create a View Component 
- Create a Tag Helper

## Pre-configuration 
1. Update the connection string in appsetting.json to your local server 
2. Run update-database. The migrations should already be created.
3. Verify the Database is set up and that you can run the application.  

## Views Review 
The following should be a review from last quarter. As such, the instructions will be a bit more vague. 
Complete the Movie Edit View 
1. Use Strongly-typed data in this view by adding `@model NowPlaying.Models.Movie` to the top of the file.
2. Create an Edit Form; the form should include many built-in tag helpers such as asp-action, asp-validation-summary, and asp-for.
3. The Form should include a link at the bottom using the asp-action helper that leads back to the Movie Index view. 
Hint: Check the Create View if you get stuck.

## Custom Tag Helper
1. Create a Tag Helper that will display the link to the email used for NowPlaying customer support. `<a href="mailto:NowPlayingCustomerSupport@nowplaying.com">Customer Support</a>`
Hint: https://learn.microsoft.com/en-us/aspnet/core/mvc/views/tag-helpers/authoring?view=aspnetcore-8.0
2. Create a folder called Helpers 
2. Create a class for your tag called `CustomerSupportTagHelper.cs`
3. Have CustomeContactTagHelper inherit from TagHelper `public class CustomerSupportTagHelper : TagHelper`
4. Create an attribute PhoneNumber. ` public string Email { get; set; }`
5. Process is a TagHelper method allowing us to create our TagHelper. override the method with ` public override void Process(TagHelperContext context, TagHelperOutput output)`
6. Within the Process method, use output.TagName is used to define the HTML tag we are creating, output.Attributes.SetAttribut is used to set its href to the PhoneNumber and output.Content.SetContent  is used to set the displayed text to PhoneNumber
```
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailto: +" + Email);
            output.Content.SetContent("Customer Support");
        
```
7. _ViewImports.cshtml is where we import our existing helper tags. To import our custom tag, add `@addTagHelper *, NowPlaying` to the file. 
8. To use the helper in the footer of _Layout.cshtml , we can invoke the helper using the Tags name; our Tag is CustomContactTagHelper, so its tag is <customer-support>. To set the PhoneNumber attribute, we can add an attribute to our helper called 'email'
```
    <div class="container">
            Phone: <customer-support phone-number="000-111-2222"></customer-support>
        </div>
```


## Extra Credit (5pt)
Create a Component that creates a dynamic DropDown menu.
Hint: https://www.youtube.com/watch?v=zK_3GQRipUM&ab_channel=JustPickandLearn