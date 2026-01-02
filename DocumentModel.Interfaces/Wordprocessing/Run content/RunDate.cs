namespace DocumentModel.Wordprocessing;
/// <summary>
///   This element specifies the presence of a date block at the current location in the run content.
///   A date block is a non-editable region of text which shall display the current date 
///   filtered through the specified date properties.
///   The date block is a legacy construct used for compatibility with older word processors, 
///   and should not be produced unless it was consumed while reading a document – 
///   it is recommended that the DATE field is used in its place.
///   A date block shall be displayed using the primary editing language of the host application, 
///   regardless of the languages specified in the parent run’s lang property (§17.3.2.20). 
/// </summary>
public class RunDate: ModelElement, IRunContent
{
  /// <summary>
  /// Specifies, which part of date is presented
  /// </summary>
  [DefaultValue(DateItem.Full)]
  public DateItem Part { get; set; }
  /// <summary>
  ///   Indicates whether this element is long.
  ///   Default - short.
  /// </summary>
  [DefaultValue(false)]
  public bool IsLong {get; set; }
}