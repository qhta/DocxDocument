namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents a custom XSL transform to use when saving a WordprocessingML document as an XML file.
  /// This interface extends <see cref="ExternalFile"/> and provides a property for the local identifier of the XSL transform, enabling advanced customization of XML output through user-defined transformations.
  /// </summary>
  public class SaveThroughXslt : ModelElement<DXW.SaveThroughXslt>
  {
    
    /// <summary>
    /// Local identifier for the XSL transform, specifying the unique solution or transform to apply.
    /// </summary>
    public string? SolutionId { get; set; }
  }