﻿namespace Taxify.Service.DTOs.CarModels;

public class CarModelUpdateDto
{
    public long Id { get; set; }    
    public string Brand { get; set; }
    public string Model { get; set; }
    public short Version { get; set; }
}
