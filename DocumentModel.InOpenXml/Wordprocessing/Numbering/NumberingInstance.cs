namespace DocumentModel.Wordprocessing;
/// <summary>
///   Specifies a unique instance of numbering information that can be referenced by zero or more paragraphs 
///   within the parent WordprocessingML document.
/// </summary>
[OpenXmlType(typeof(DXW.NumberingInstance))]
[DataContract]
[XmlRoot("NumberingInstance", Namespace = "DocumentModel.Wordprocessing")]
public partial class NumberingInstance : ModelElement<DXW.NumberingInstance>
{
 /// <summary>
 ///   A value of 0 for NumberId shall never be used to point to a numbering definition instance,
 ///   and shall instead only be used to designate the removal of numbering properties 
 ///   at a particular level in the style hierarchy (typically via direct formatting). 
 /// </summary>
 [OpenXmlProperty(nameof(DXW.NumberingInstance.NumberID))]
 [Required]
 public Int32? NumberID { get => _NumberID; set => UpdateField(ref _NumberID, value, nameof(NumberID)); }
 private Int32? _NumberID;

 /// <summary>
 ///   Associates a unique hexadecimal ID to the numbering definition instance.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.NumberingInstance.DurableId))]
 public Int32? DurableId { get => _DurableId; set => UpdateField(ref _DurableId, value, nameof(DurableId)); }
 private Int32? _DurableId;

 /// <summary>
 ///   Specifies the abstract numbering definition information 
 ///   whose properties shall be inherited by the parent numbering definition instance.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.NumberingInstance.AbstractNumId))]
 public Int32? AbstractNumId { get => _AbstractNumId; set => UpdateField(ref _AbstractNumId, value, nameof(AbstractNumId)); }
 private Int32? _AbstractNumId;

 /// <summary>
 ///  Collection of NumLevelOverride elements
 /// </summary>
 [OpenXmlElementCollection(typeof(DXW.NumberingInstance))]
 [OpenXmlUpdateData(nameof(UpdateLevelOverrides))]
 [OpenXmlLoadData(nameof(LoadLevelOverrides))]
 public NumberingLevelOverrides LevelOverrides
 {
  get
  {
   if (_NumberingLevelOverrides == null)
    _NumberingLevelOverrides = new NumberingLevelOverrides(this);
   return _NumberingLevelOverrides;
  }

  set => UpdateField(ref _NumberingLevelOverrides, value, nameof(LevelOverrides));
 }
 private NumberingLevelOverrides? _NumberingLevelOverrides;

 /// <summary>
 /// Updates the level overrides in the specified OpenXml element with level overrides defined in the LevelOverrides collection.  
 /// </summary>
 /// <remarks>This method passes the specified element to the LevelOverrides collection for updating.</remarks>
 /// <param name = "element">The OpenXml element to update. Must be of type <see cref = "DXW.NumberingInstance"/>.</param>
 /// <exception cref = "ArgumentException">Thrown if <paramref name = "element"/> is not of type <see cref = "DXW.NumberingInstance"/>.</exception>
 public void UpdateLevelOverrides(DX.OpenXmlElement element)
 {
  LevelOverrides.UpdateOverrides(element);
 }

 /// <summary>
 /// Loads level overrides from the specified OpenXmlElement into the LevelOverrides collection, replacing any existing LevelOverrides.
 /// </summary>
 /// <remarks>This method passes the specified element to the LevelOverrides collection for loading.</remarks>
 /// <param name = "element">The OpenXmlElement containing the level overrides to load. Must be of type DXW.NumberingInstance.</param>
 /// <exception cref = "ArgumentException">Thrown if the provided element is not of type DXW.NumberingInstance.</exception>
 public void LoadLevelOverrides(DX.OpenXmlElement element)
 {
  LevelOverrides.LoadOverrides(element);
 }
}