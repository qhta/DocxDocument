using DocumentModel.BaseTypes;
namespace DocumentModel.Wordprocessing;
/// <summary>
///   This element specifies the presence of a simple field at the current location in the document. 
///   The semantics of this field are defined via its field codes.
/// </summary>
public class SimpleField: ElementCollection<IModelElement>, IParagraphContent, ISdtRunContent, IBidirectionalContent, DMM.IMathArgumentContent
{
  /// <summary>
  ///   Specifies the field codes for the simple field. The possible field codes are defined in §17.16.5.
  /// </summary>
  public string? Instruction { get; set; }
  /// <summary>
  ///   Specifies that the parent field shall not have its field result recalculated, 
  ///   even if an application attempts to recalculate the results of all fields in the document 
  ///   or a recalculation is explicitly requested.
  /// </summary>
  public bool? FieldLock { get; set; }
  /// <summary>
  ///   Specifies that this field has been flagged by an application to indicate 
  ///   that its current results are no longer correct (stale) 
  ///   due to other modifications made to the document, 
  ///   and these contents should be updated before they are displayed 
  ///   if this functionality is supported by the next processing application.
  /// </summary>
  public bool? Dirty { get; set; }
  /// <summary>
  ///   Apecifies custom field data which shall be associated with the parent field. 
  ///   No information or semantics are applied to the contents of this data by ISO/IEC 29500, 
  ///   and therefore this field can be used as desired to store additional application-defined data with the field. 
  ///   However, applications should not lose the contents of this custom data if they do not understand or utilize it 
  ///   (i.e. the information should continue to be saved with the file).
  /// </summary>
  public string? FieldData { get; set; }
}