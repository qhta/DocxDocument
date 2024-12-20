﻿namespace ModelGen;

public record FileModel
{
  public FileModel(string name)
  {
    Filename = name;
  }

  public string Filename { [DebuggerStepThrough] get; set; }
}
