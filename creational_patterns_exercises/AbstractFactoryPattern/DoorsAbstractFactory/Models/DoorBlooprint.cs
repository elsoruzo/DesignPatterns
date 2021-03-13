﻿namespace DoorsAbstractFactory.Models
{
    public class DoorBlooprint: IDoorBlooprint
    {
      public int High { get; set; }
      public int Width { get; set; }
      public int Depth { get; set; }
      public string Material { get; set; }
      public string Color { get; set; }
    }
}