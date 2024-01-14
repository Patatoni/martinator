﻿using System.ComponentModel.DataAnnotations;

namespace backend.Models;

public class Recording
{
    [Key] // Primary key and auto-generated by the database
    public long Id { get; set; }

    [Required]
    public string Path { get; set; }

    [Required]
    public string Name { get; set; }

    [MaxLength(500)]
    public string? Description { get; set; }

    [Required]
    public DateOnly StartDate { get; set; }

    [Required]
    public DateOnly EndDate { get; set; }

    [Required]
    public TimeOnly StartTime { get; set; }

    [Required]
    public TimeOnly EndTime { get; set; }

    [Required]
    public TimeSpan Duration { get; set; }

    [Required]
    public long Size { get; set; }

    public Recording() { }
    public Recording(long id, string path, string name, string description, DateOnly startDate, DateOnly endDate, TimeOnly startTime, TimeOnly endTime, long size, TimeSpan duration)
    {
        Id = id;
        Path = path;
        Name = name;
        Description = description;
        StartDate = startDate;
        EndDate = endDate;
        StartTime = startTime;
        EndTime = endTime;
        Size = size;
        Duration = duration;
    }



}
