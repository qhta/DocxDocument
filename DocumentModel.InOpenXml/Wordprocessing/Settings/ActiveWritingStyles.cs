namespace DocumentModel.Wordprocessing;
/// <summary>
/// Collection of active writing styles applied to the document.
/// </summary>
public class ActiveWritingStyles: ElementCollection<ActiveWritingStyle>
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  public ActiveWritingStyles()
  {
  }

  /// <summary>
  /// Initializes the collection with the specified styles.
  /// </summary>
  /// <param name="styles">Initial collection of active writing styles.</param>
  public ActiveWritingStyles(IEnumerable<ActiveWritingStyle> styles): base(styles)
  {
  }

  protected override object? GetUpdatableOpenXmlElement()
  {
    throw new NotImplementedException();
  }
}