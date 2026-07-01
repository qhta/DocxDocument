namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a collection of numbering level elements in a WordprocessingML document.
/// </summary>
[OpenXmlUpdateData(nameof(UpdateLevels))]
[OpenXmlLoadData(nameof(LoadLevels))]
[DataContract]
[XmlRoot("NumberingLevels", Namespace = "DocumentModel.Wordprocessing")]
public class NumberingLevels : ModelElementCollection<NumberingLevel, DXW.AbstractNum, DXW.Level>
{
 /// <summary>
 /// Default constructor.
 /// </summary>
 public NumberingLevels()
 {
 }

 /// <summary>
 /// Initializing constructor.
 /// </summary>
 /// <param name = "numbering"></param>
 public NumberingLevels(AbstractNumbering numbering)
 {
  Numbering = numbering;
 }

 /// <summary>
 /// Parent numbering definition associated with this element.
 /// </summary>
 /// <remarks>Assigning this property establishes the numbering format for the current element by linking it to
 /// an existing AbstractNumbering instance. The property should be set to a valid AbstractNumbering object to ensure
 /// correct numbering behavior. Setting this property to null removes the association with any numbering
 /// definition.</remarks>
 [XmlIgnore]
 [JsonIgnore]
 [NotMapped]
 public AbstractNumbering? Numbering { get => Parent as AbstractNumbering; set => Parent = value; }

 /// <summary>
 /// Retrieves the updatable abstract numbering element associated with the current numbering instance, if available.
 /// </summary>
 /// <remarks>This method returns the updatable element from the underlying numbering object. Ensure that the
 /// numbering instance is not <see langword="null"/> before calling this method to avoid unexpected <see 
 ///langword="null"/> results.</remarks>
 /// <returns>An instance of <see cref = "DXW.AbstractNum"/> representing the updatable abstract numbering element, or <see 
 ///langword="null"/> if no such element exists.</returns>
 public override DX.OpenXmlElement? GetUpdatableObject()
 {
  return Numbering?.GetUpdatableObject() as DXW.AbstractNum;
 }

 /// <summary>
 /// Updates the levels of the specified numbering definition by removing all existing levels and adding new levels
 /// from the current instance.
 /// </summary>
 /// <remarks>This method modifies the specified numbering definition by clearing its existing levels and
 /// appending new levels based on the current instance. Use this method to synchronize the levels of an AbstractNum
 /// element with the current collection.</remarks>
 /// <param name = "element">The OpenXmlElement representing the numbering definition to update. Must be of type AbstractNum.</param>
 /// <exception cref = "ArgumentException">Thrown if the provided element is not of type AbstractNum.</exception>
 public void UpdateLevels(DX.OpenXmlElement element)
 {
  if (element is not DXW.AbstractNum numbering)
   throw new ArgumentException($"Expected element of type {typeof(DXW.AbstractNum).FullName}, but got {element.GetType().FullName}.");
  numbering.RemoveAllChildren<DXW.Level>();
  foreach (var numLevel in this)
  {
   var level = OpenXmlElementConverter.ConvertTo(numLevel, typeof(DXW.Level)) as DXW.Level;
   numbering.AppendChild(level);
  }
 }

 /// <summary>
 /// Loads numbering from the specified OpenXmlElement into the current collection, replacing any existing numbering.
 /// </summary>
 /// <remarks>This method clears the current collection before loading new numbering. The collection will contain
 /// only the numbering loaded from the specified element after the method completes.</remarks>
 /// <param name = "element">The OpenXmlElement containing the numbering to load. Must be of type DXW.Numbering.</param>
 /// <exception cref = "ArgumentException">Thrown if the provided element is not of type DXW.Numbering.</exception>
 public void LoadLevels(DX.OpenXmlElement element)
 {
  if (element is not DXW.AbstractNum numbering)
   throw new ArgumentException($"Expected element of type {typeof(DXW.AbstractNum).FullName}, but got {element.GetType().FullName}.");
  SetLoading(true);
  var levelElements = numbering.Elements<DXW.Level>().ToArray();
  this.Clear();
  foreach (var openXmlElement in levelElements)
  {
   var numLevel = OpenXmlElementConverter.ConvertFrom(openXmlElement, typeof(DMW.NumberingLevel)) as DMW.NumberingLevel;
   this.Add(numLevel!);
  }

  SetLoading(false);
 }
}