﻿using Movies.API.Models.Enums;

namespace Movies.API.Models;
public class Movie
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public DateTime LaunchDate { get; set; }
    public MovieGenre Genre { get; set; }
    public List<MovieReview> Reviews { get; } = [];

    public Movie()
    {
        
    }
}
