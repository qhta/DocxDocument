namespace DocumentModel.Wordprocessing;
/// <summary>
///   Collection of NumberingInstance elements
/// </summary>
[OpenXmlUpdateData(nameof(UpdateNumberings))]
[OpenXmlLoadData(nameof(LoadNumberings))]
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
  /// <param name = "numbering"></param>
  public NumberingInstances(Numbering numbering)
  {
    Numbering = numbering;
  }

  /// <summary>
  /// Parent numbering element that contains this collection of numbering instance. 
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public Numbering? Numbering { get => Parent as Numbering; set => SetParent(value); }

  /// <summary>
  /// Gets updatable element for this collection of numbering instance,
  /// which is the <see cref="DXW.Numbering"/> element that contains the individual <see cref="DXW.NumberingInstance"/> elements
  /// representing each abstract AbstractNum.
  /// </summary>
  /// <returns></returns>
  public override DX.OpenXmlElement? GetUpdatableElement()
  {
    return Numbering?.GetUpdatableElement() as DXW.Numbering;
  }

  /// <summary>
  /// Updates the numbering in the specified OpenXml element by removing all existing numbering and adding new numbering instance
  /// in the current collection.  
  /// </summary>
  /// <remarks>This method replaces all numbering in the target element with those abstract in the current
  /// collection. Ensure that the numbering being added are properly configured for the document context.</remarks>
  /// <param name="element">The OpenXml element to update. Must be of type <see cref="DXW.Numbering"/>.</param>
  /// <exception cref="ArgumentException">Thrown if <paramref name="element"/> is not of type <see cref="DXW.Numbering"/>.</exception>
  public void UpdateNumberings(DX.OpenXmlElement element)
  {
    if (element is not DXW.Numbering numbering)
      throw new ArgumentException($"Expected element of type {typeof(DXW.Numbering).FullName}, but got {element.GetType().FullName}.");
    numbering.RemoveAllChildren<DXW.NumberingInstance>();
    foreach (var modeItem in this)
    {
      var openXmlChild = OpenXmlElementConverter.ConvertTo(modeItem, typeof(DXW.NumberingInstance)) as DXW.NumberingInstance;
      numbering.AppendChild(openXmlChild);
    }
  }

  /// <summary>
  /// Loads numbering from the specified OpenXmlElement into the current collection, replacing any existing numbering.
  /// </summary>
  /// <remarks>This method clears the current collection before loading new numbering. The collection will contain
  /// only the numbering loaded from the specified element after the method completes.</remarks>
  /// <param name="element">The OpenXmlElement containing the numbering to load. Must be of type DXW.Numbering.</param>
  /// <exception cref="ArgumentException">Thrown if the provided element is not of type DXW.Numbering.</exception>
  public void LoadNumberings(DX.OpenXmlElement element)
  {
    if (element is not DXW.Numbering numbering)
      throw new ArgumentException($"Expected element of type {typeof(DXW.Numbering).FullName}, but got {element.GetType().FullName}.");
    SetIsLoading(true);
    var openXmlChildren = numbering.Elements<DXW.NumberingInstance>().ToArray();
    this.Clear();
    foreach (var openXmlChild in openXmlChildren)
    {
      var modelItem = OpenXmlElementConverter.ConvertFrom(openXmlChild, typeof(DMW.NumberingInstance)) as DMW.NumberingInstance;
      this.Add(modelItem!);
    }
    SetIsLoading(false);
  }

}