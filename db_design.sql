IF OBJECT_ID(N'dbo.invitation', N'U') IS NOT NULL  
   DROP TABLE [dbo].invitation;  
GO

IF OBJECT_ID(N'dbo.submission', N'U') IS NOT NULL  
   DROP TABLE [dbo].submission;  
GO

IF OBJECT_ID(N'dbo.answer', N'U') IS NOT NULL  
   DROP TABLE [dbo].answer;  
GO

IF OBJECT_ID(N'dbo.question', N'U') IS NOT NULL  
   DROP TABLE [dbo].question;  
GO

IF OBJECT_ID(N'dbo.survey', N'U') IS NOT NULL  
   DROP TABLE [dbo].survey;  
GO


IF OBJECT_ID(N'dbo.[user]', N'U') IS NOT NULL  
   DROP TABLE [dbo].[user];  
GO


CREATE TABLE [user]
(
    id INT PRIMARY KEY  IDENTITY(1,1),
	name VARCHAR(55) NOT NULL,
	password VARCHAR(55) NOT NULL,
    email VARCHAR(255) NOT NULL UNIQUE,
    mobile VARCHAR(15) NOT NULL,
    isActive BIT NOT NULL,
    role VARCHAR(255) NOT NULL
);

CREATE TABLE survey
(
    id INT PRIMARY KEY IDENTITY(1,1),
    title VARCHAR(255) NOT NULL,
    createdDate DATETIME NOT NULL,
    updatedDate DATETIME NOT NULL
);

CREATE TABLE question
(
    id INT PRIMARY KEY IDENTITY(1,1),
    surveyId INT NOT NULL,
    text NVARCHAR(MAX) NOT NULL,
    FOREIGN KEY (surveyId) REFERENCES survey(id)
);

CREATE TABLE answer
(
    id INT PRIMARY KEY IDENTITY(1,1),
    questionId INT NOT NULL,
    text NVARCHAR(MAX) NOT NULL,
    isCorrect BIT NOT NULL,
    FOREIGN KEY (questionId) REFERENCES question(id)
);


CREATE TABLE invitation
(
    id INT PRIMARY KEY IDENTITY(1,1),
    surveyId INT NOT NULL,
    userId INT NOT NULL,
    invitationLink NVARCHAR(MAX) NOT NULL,
    FOREIGN KEY (surveyId) REFERENCES survey(id),
    FOREIGN KEY (userId) REFERENCES [user](id)
);


CREATE TABLE submission
(
    id INT PRIMARY KEY IDENTITY(1,1),
    surveyId INT NOT NULL,
    userId INT NOT NULL,
    answer1 INT NOT NULL,
    answer2 INT NOT NULL,
    answer3 INT NOT NULL,
    score INT NOT NULL,
    FOREIGN KEY (surveyId) REFERENCES survey(id),
    FOREIGN KEY (userId) REFERENCES [user](id)
);

