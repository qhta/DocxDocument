using DocumentFormat.OpenXml.Office2019.Excel.RichData2;

namespace DocumentModel;

/// <summary>
/// Collection of model elements which wrap OpenXml elements.
/// </summary>
/// <typeparam name="T"></typeparam>
/// <typeparam name="W">OpenXmlElement</typeparam>
public class ElementCollection<T, W> : ElementCollection<T>
  where T : IModelElement<W> where W: DX.OpenXmlElement
{

  /// <summary>
  /// Default constructor. Does nothing.
  /// </summary>
  public ElementCollection() { }

  /// <summary>
  /// Item creating constructor
  /// </summary>
  /// <param name="source"></param>
  public ElementCollection(IEnumerable<W> source)
  {
    var constructor = typeof(T).GetConstructor(new Type[] { typeof(W) });
    if (constructor != null)
      foreach (var item in source)
        Add((T)constructor.Invoke(new object[]{ item }));
  }
}
