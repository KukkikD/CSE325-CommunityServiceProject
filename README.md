# Community Connect

Community Connect is a .NET Blazor web application developed for CSE 325 Software Development.

The application connects community organizers with volunteers who want to serve. Organizers can create and manage community service opportunities and volunteer tasks, while community members can browse available opportunities and sign up to help.

## Features

### Service Opportunities

- Browse available community service opportunities
- View opportunity details, including date, location, organizer, and status
- Create new service opportunities
- Edit and delete opportunities
- Track opportunity status as Open, Filled, or Completed

### Volunteer Tasks

- Organizers can add volunteer tasks to their service opportunities
- Edit and delete volunteer tasks
- Specify the number of volunteers needed for each task

### Volunteer Sign-Up

- Volunteers can select a task and sign up to help
- View their current task sign-ups
- Cancel a volunteer sign-up
- Prevent duplicate sign-ups for the same task

### Organizer Dashboard

- View opportunities created by the logged-in organizer
- Manage opportunity details and volunteer tasks
- Organizer-only controls are protected by authorization

### User Accounts and Security

- User registration and login
- Account profile management
- Email and password management
- Two-factor authentication support
- Authorization protects organizer-only actions

### Responsive and Accessible Design

- Responsive layout for desktop, tablet, and mobile devices
- Consistent Community Connect branding and interface
- Form validation and user feedback
- Accessibility improvements reviewed with Lighthouse

---

## Getting Started

### Prerequisites

Before running the application, make sure the following are installed:

- .NET SDK
- Git
- A code editor or IDE such as Visual Studio or Visual Studio Code

### Clone the Repository

Clone the project from GitHub:

    git clone https://github.com/KukkikD/CSE325-CommunityServiceProject.git

Move into the project directory:

    cd CSE325-CommunityServiceProject

### Restore Dependencies

Run:

    dotnet restore

### Build the Application

Run:

    dotnet build

### Run the Application

Run:

    dotnet run

After the application starts, open the local URL displayed in the terminal.

---

## Basic User Guide

### Create an Account

1. Open Community Connect.
2. Select **Register**.
3. Enter the required account information.
4. Create your account.
5. Log in to access authenticated features.

### Browse Opportunities

1. Go to the Home page.
2. Browse the available community service opportunities.
3. Select an opportunity to view its details.
4. Review the date, location, description, available tasks, and opportunity status.

### Create an Opportunity

Logged-in users can create service opportunities.

1. Select **Create Opportunity** from the navigation menu.
2. Enter the opportunity title, description, date, and location.
3. Submit the form.
4. The new opportunity can then be managed by its organizer.

### Manage Your Opportunities

1. Select **My Opportunities**.
2. View the opportunities you created.
3. Use the available actions to view, edit, or delete an opportunity.

Only the organizer who created an opportunity can modify it.

### Add Volunteer Tasks

From an opportunity you organize:

1. Open the opportunity details.
2. Select **Add Task**.
3. Enter the task title and description.
4. Enter the number of volunteers needed.
5. Save the task.

Organizers can also edit or delete their existing tasks.

### Volunteer for an Opportunity

1. Open an opportunity.
2. Select **Sign Up to Help**.
3. Choose an available volunteer task.
4. Submit the sign-up.

The application prevents duplicate sign-ups for the same task.

### Manage Volunteer Sign-Ups

Volunteers can view their current task sign-ups and cancel a sign-up when needed.

### Manage Your Account

Select **My Account** to access account settings.

Users can manage:

- Profile information
- Email settings
- Password
- Two-factor authentication
- Personal account data

---

## Authorization

Community Connect uses authorization to protect organizer-only actions.

Only the organizer who created an opportunity can:

- Edit the opportunity
- Delete the opportunity
- Add tasks to the opportunity
- Edit its tasks
- Delete its tasks

Other users can still view available opportunities and volunteer for available tasks.

Unauthorized attempts to access protected management pages are redirected to an access-restricted page.

---

## Validation and Error Handling

The application includes validation and user feedback for important forms and actions.

Examples include:

- Required opportunity information
- Required task titles
- Minimum volunteer requirements
- Prevention of duplicate volunteer sign-ups
- Authorization checks for protected actions
- Clear validation and access-restriction messages

---

## Testing and Quality Assurance

The application has been tested for:

- Opportunity creation, editing, and deletion
- Volunteer task creation, editing, and deletion
- Volunteer sign-up and cancellation
- Authentication and authorization
- Invalid and missing form input
- Navigation and user workflows
- Desktop and mobile responsive layouts
- Accessibility and browser best practices
- Network requests and page loading behavior

Lighthouse was used during final UI testing to review accessibility, performance, and best practices.

---

## Deployment

Cloud deployment is part of the final project release process.

The deployed application URL will be added here after the production deployment and final cloud testing are completed.

**Deployment URL:** https://cse325-communityproject-c5apf6ckhvbthmaa.chilecentral-01.azurewebsites.net/

After deployment, the team will verify:

- The public URL is accessible
- Registration and login work correctly
- Authorization works correctly
- Opportunities and tasks can be created and managed
- Volunteer sign-up works correctly
- Saved application data persists correctly

---

## Technologies

- .NET
- ASP.NET Core
- Blazor
- Entity Framework Core
- ASP.NET Core Identity
- Bootstrap
- CSS

---

## Team Members

- Andres Daniel Costanzi
- Amornrat Dizon Howard
- Lievelyn De La Trinidad Zapata
- Daniel Parra

---

## Course

**CSE 325 – .NET Software Development**  
Brigham Young University–Idaho
