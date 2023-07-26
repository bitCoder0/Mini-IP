using System;


/// <summary>
/// api request schema to be desrialized
/// </summary>
public class IPAPISchema
{

    public string? query { get; set; }
    public string? country { get; set; }
    public string? city { get; set; }
    public string? isp { get; set; }

}
