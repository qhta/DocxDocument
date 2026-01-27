namespace DocumentModel.Wordprocessing;
/// <summary>
///   Specifies a unique instance of numbering information that can be referenced by zero or more paragraphs 
///   within the parent WordprocessingML document.
/// </summary>
[OpenXmlType(typeof(DXW.NumberingInstance))]
public partial class NumberingInstance : ModelElement<DXW.NumberingInstance>
{
 /// <summary>
 ///   A value of 0 for NumberId shall never be used to point to a numbering definition instance,
 ///   and shall instead only be used to designate the removal of numbering properties 
 ///   at a particular level in the style hierarchy (typically via direct formatting). 
 /// </summary>
 [OpenXmlProperty(nameof(DXW.NumberingInstance.NumberID))]
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
 public NumLevelOverrides? LevelOverrides { get => _LevelOverrides; set => UpdateField(ref _LevelOverrides, value, nameof(LevelOverrides)); }

 private NumLevelOverrides? _LevelOverrides;
}