﻿namespace dev_test.DTOs
{
    public class AnswerDto
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string? Text { get; set; }
        public bool IsCorrect { get; set; }
    }
}
