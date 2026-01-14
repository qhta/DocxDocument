namespace DocumentModel.Wordprocessing
{
  /// <summary>
  /// Specifies the type of building block, corresponding to Microsoft.Office.Interop.Word.WdBuildingBlockTypes.
  /// </summary>
  public enum BuildingBlockType
  {
    /// <summary>AutoText building block.</summary>
    AutoText = 1,
    /// <summary>CoverPage building block.</summary>
    CoverPage = 2,
    /// <summary>Equations building block.</summary>
    Equations = 3,
    /// <summary>Footers building block.</summary>
    Footers = 4,
    /// <summary>Headers building block.</summary>
    Headers = 5,
    /// <summary>PageNumber building block.</summary>
    PageNumber = 6,
    /// <summary>Tables building block.</summary>
    Tables = 7,
    /// <summary>TextBox building block.</summary>
    TextBox = 8,
    /// <summary>Watermarks building block.</summary>
    Watermarks = 9
  }
}
