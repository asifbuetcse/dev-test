CREATE TABLE [user]
(
    id INT PRIMARY KEY,
    email VARCHAR(255) NOT NULL UNIQUE,
    mobile VARCHAR(15) NOT NULL,
    isActive BIT NOT NULL,
    role VARCHAR(255) NOT NULL
);

CREATE TABLE survey
(
    id INT PRIMARY KEY,
    title VARCHAR(255) NOT NULL,
    created_date DATETIME NOT NULL,
    updated_date DATETIME NOT NULL
);

CREATE TABLE question
(
    id INT PRIMARY KEY,
    survey_id INT NOT NULL,
    text NVARCHAR(MAX) NOT NULL,
    FOREIGN KEY (survey_id) REFERENCES survey(id)
);

CREATE TABLE answer
(
    id INT PRIMARY KEY,
    question_id INT NOT NULL,
    text NVARCHAR(MAX) NOT NULL,
    is_correct BIT NOT NULL,
    FOREIGN KEY (question_id) REFERENCES question(id)
);


CREATE TABLE invitation
(
    id INT PRIMARY KEY,
    survey_id INT NOT NULL,
    user_id INT NOT NULL,
    invitation_link NVARCHAR(MAX) NOT NULL,
    FOREIGN KEY (survey_id) REFERENCES survey(id),
    FOREIGN KEY (user_id) REFERENCES [user](id)
);


CREATE TABLE submission
(
    id INT PRIMARY KEY,
    survey_id INT NOT NULL,
    user_id INT NOT NULL,
    answer1 INT NOT NULL,
    answer2 INT NOT NULL,
    answer3 INT NOT NULL,
    score INT NOT NULL,
    FOREIGN KEY (survey_id) REFERENCES survey(id),
    FOREIGN KEY (user_id) REFERENCES [user](id)
);

