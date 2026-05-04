namespace DocumentModel.Wordprocessing;
/// <summary>
///   Collection of AbstractNum elements.
/// </summary>
[XmlRoot("AbstractNumberings", Namespace = "DocumentModel.Wordprocessing")]
public partial class AbstractNumberings : ModelElementCollection<AbstractNumbering, DXW.Numbering, DXW.AbstractNum>
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  public AbstractNumberings()
  {
  }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name = "numbering">The parent numbering element.</param>
  public AbstractNumberings(Numbering numbering) : base(numbering, numbering?.GetUpdatableElement() as DXW.Numbering)
  {
  }

}