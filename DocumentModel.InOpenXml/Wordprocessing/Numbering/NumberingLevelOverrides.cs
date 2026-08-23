namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a collection of numbering level override elements in a WordprocessingML document.
/// </summary>
[OpenXmlType(typeof(NumberingLevelOverride))]
[DataContract]
[XmlRoot("NumberingLevelOverrides", Namespace = "DocumentModel.Wordprocessing")]
public class NumberingLevelOverrides : ModelElementCollection<NumberingLevelOverride, DXW.NumberingInstance, DXW.LevelOverride>
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  public NumberingLevelOverrides()
  {
  }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name = "numbering"></param>
  public NumberingLevelOverrides(NumberingInstance numbering)
  {
    Numbering = numbering;
  }

  /// <summary>
  /// Parent numbering instance element that contains this collection of numbering level overrides. 
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public NumberingInstance? Numbering { get => Parent as NumberingInstance; set => SetParent(value); }

  /// <summary>
  /// Gets updatable element for this collection of numbering instance,
  /// which is the <see cref = "DXW.NumberingInstance"/> element that contains the individual <see cref = "DXW.NumberingLevelOverride"/> elements.
  /// </summary>
  /// <returns></returns>
  public override object? GetUpdatableObject(object? context = null)
  {
    return Numbering?.GetUpdatableObject(context) as DXW.NumberingInstance;
  }

  /// <summary>
  /// Updates the specified OpenXml element by removing all existing items and adding new items from the current collection.
  /// </summary>
  /// <remarks>This method replaces all items in the target element with those contained in the current
  /// collection. Ensure that the numbering being added are properly configured for the document context.</remarks>
  /// <param name = "element">The OpenXml element to update. Must be of type <see cref = "DXW.NumberingInstance"/>.</param>
  /// <exception cref = "ArgumentException">Thrown if <paramref name = "element"/> is not of type <see cref = "DXW.NumberingInstance"/>.</exception>
  public void UpdateOverrides(DX.OpenXmlElement element)
  {
    if (element is not DXW.NumberingInstance numberingInstance)
      throw new ArgumentException($"Expected element of type {typeof(DXW.NumberingInstance).FullName}, but got {element.GetType().FullName}.");
    numberingInstance.RemoveAllChildren<DXW.LevelOverride>();
    foreach (var modeItem in this)
    {
      var openXmlChild = OpenXmlElementConverter.ConvertTo(modeItem, typeof(DXW.LevelOverride)) as DXW.LevelOverride;
      numberingInstance.AppendChild(openXmlChild);
    }
  }

  /// <summary>
  /// Loads items from the specified OpenXmlElement into the current collection, replacing any existing items.
  /// </summary>
  /// <remarks>This method clears the current collection before loading new numbering. The collection will contain
  /// only the numbering loaded from the specified element after the method completes.</remarks>
  /// <param name = "element">The OpenXmlElement containing the numbering to load. Must be of type DXW.Numbering.</param>
  /// <exception cref = "ArgumentException">Thrown if the provided element is not of type DXW.Numbering.</exception>
  public void LoadOverrides(DX.OpenXmlElement element)
  {
    if (element is not DXW.NumberingInstance numbering)
      throw new ArgumentException($"Expected element of type {typeof(DXW.NumberingInstance).FullName}, but got {element.GetType().FullName}.");
    SetIsLoading(true);
    var openXmlChildren = numbering.Elements<DXW.LevelOverride>().ToArray();
    this.Clear();
    foreach (var openXmlChild in openXmlChildren)
    {
      var modelItem = OpenXmlElementConverter.ConvertFrom(openXmlChild, typeof(DMW.NumberingLevelOverride)) as DMW.NumberingLevelOverride;
      this.Add(modelItem!);
    }

    SetIsLoading(false);
  }
}