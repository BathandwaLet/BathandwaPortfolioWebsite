# Portfolio Website

## Project Title
Portfolio website built using ASP.NET MVC.

## Project Description
This is a website built using ASP.NET MVC, Razor views and JavaScript. The main function is to display all of my IT related projects, experience and qualifications.

## Features
- Persistent navigation bar
- 8 pages with various content.
- Data-driven pages using data from jsons (certificates and projects page)


## Planned Features
- Website colour palette
- Website animations
- linking detail pages to the projects index page
  

## Tech Stack
- ASP.NET MVC
- JavaScript

  
## How To Run
- Clone repo
- Open in any IDE that supports C#/ ASP.NET application (Visual Studio, Rider).
- Run the application

## Project Structure
### BathandwaPortfolioWebsite.csproj
- Dependecies (Imports and .NET 10.0)

### Properties
- launchSettings.json

### wwwroot
#### certificates
- ai_skills_hub
- fCC

#### css
- site.css
  
#### images
- certificates
- contactIcons
- profileimage
- projects
- skillsbadge

#### js


#### lib

### Controllers
- AboutController.cs
- CertificatesController.cs
- ContactController.cs
- EducationController.cs
- ExperienceController.cs
- HomeController.cs
- ProjectsController.cs
- SkillsController.cs

### Data
- certificates.json
- projects.json

### Models
- Certificate.cs
- ErrorViewModel.cs
- Project.cs
- SkillGroup.cs

### Views (Razor views, pages that will display the information using the models)
#### About
- Index.cshtml

#### Certificates
- Index.cshtml (Detail fetched from certificates.json)

#### Contact
- Index.cshtml

#### Education
- Index.cshtml

#### Experience
- Index.cshtml

#### Home
- Index.cshtml

#### Projects
- Detail.cshtml (Provides additional detail of the projects from projects.json)
- Index.cshtml

#### Shared
- _Layout.cshtml
- Error..cshtml

#### Skills
- Index.cshtml

### Program.cs (App entry point)

### appsetings.json (Application configuration)

## License
This project is under the MIT License.

## Screenshots

## Author
**Bathandwa L Maphumulo**  
Email: bmap750@gmail.com  
LinkedIn: [in/bathandwa-maphumulo-216177180](https://www.linkedin.com/in/bathandwa-maphumulo-216177180/)
