namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Specifies the background for every page of the document containing the background element in a WordprocessingML document.
  /// The document background is the image or fill for the entire page surface, appearing behind all other document content.
  /// </summary>
  public interface DocumentBackground
  {
    
    /// <summary>
    /// Color for the background of the document, specifying the fill color applied to all pages.
    /// </summary>
    public Color? Color { get; set; }
    
    /// <summary>
    /// Background element, specifying additional background properties such as images or patterns.
    /// </summary>
    public DMV.Background? Background { get; set; }
  }