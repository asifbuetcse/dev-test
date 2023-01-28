# dev-test

##Backgroud
Programming tutorial's show us a land of promise where everything happens as we think; as soon as we think. But real world doesn’t work that way most of the times. Here; we spend hours debugging some CORS error or thinking why the heck our database table Id column is not auto-incrementing. I have participated in a coding interview which spans 2 days and these repository is based on that experience – what I was thinking at each stage; what is the issue that I was facing and how I tried to resolve them.

The accompanying blog post series is here -
`<link>`: https://asifulhaque.com/when-programming-tutorials-doesnt-work-part-1/

## Project Requirements

I need to design a survey system. It will have 3 Main screen.

- Admin user will create an user. User email will be unique. User will also have name, mobile, isActive field.
- Admin will create a survey. For simplicity a survey will have only 3 questions. Each questions will have 4 answers. only one answer will be correct answer.
- User can participate in the survey with a link from email.
- The flow would be like this – User create page with user list in the bottom (with number of surveys participated) -> survey creation page -> survey list page with option to send invitation to all ACTIVE users -> user participating in survey.

### Requirement and validations:

- Using Dot net core (not webform or anything)
- Using front end technology (angular/react)
- Using entity framework
- Each survey questions will have only one answer
- Proper front end validation
- Sending users a mail with the invitation link

## What the repository contains

- Frontend folder for angular front-end project
- Backend folder for dot-net core api project
- Single sql file of database design

## How this repository is designed

There are branches titled version_x where I posted incremental update of the code.
