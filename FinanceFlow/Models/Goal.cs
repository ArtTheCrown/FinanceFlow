using System;

public class Goal
{
    public int Id { get; set; }
    public string Description { get; set; }
    public decimal TargetAmount { get; set; }
    public decimal CurrentAmount { get; set; }
    public DateTime TargetDate { get; set; }
    public string UserId { get; set; }
}