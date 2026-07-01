namespace DocumentModel.Wordprocessing;
/// <summary>
///   Collection of NumberingInstance elements
/// </summary>
[DataContract]
[XmlRoot("NumberingInstances", Namespace = "DocumentModel.Wordprocessing")]
public class NumberingInstances : ModelElementCollection<NumberingInstance, DXW.Numbering, DXW.NumberingInstance>
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  public NumberingInstances()
  {
  }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name = "numbering">The parent numbering element.</param>
  public NumberingInstances(Numbering numbering) : base(numbering, numbering?.GetUpdatableElement() as DXW.Numbering)
  {
  }
}