﻿namespace dev_test.DTOs
{
    public class InvitationDto
    {
        public int Id { get; set; }
        public int SurveyId { get; set; }
        public int UserId { get; set; }
        public string? InvitationLink { get; set; }
    }
}
