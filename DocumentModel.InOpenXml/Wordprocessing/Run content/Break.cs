namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents a break element placed at the current location in the run content of a WordprocessingML document.
  /// A break is a special character used to override normal line breaking, with behavior determined by its type and clear attribute values. This enables advanced control over text flow, line, and page breaks within document content.
  /// </summary>
  public class Break : ModelElement<DXW.Break>, IRunContent
  {
    
    /// <summary>
    /// Type of break to insert, specifying the kind of break (e.g., line, page, column, text wrapping).
    /// </summary>
    public BreakKind? Type { get; set; }
    
    /// <summary>
    /// Restart location for text wrapping break, specifying where text should resume after the break (e.g., left, right, all).
    /// </summary>
    public BreakTextRestartLocationKind? Clear { get; set; }
  }