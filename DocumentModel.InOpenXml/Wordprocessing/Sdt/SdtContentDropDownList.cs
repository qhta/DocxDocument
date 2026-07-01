namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the configuration for drop-down list content controls in a structured document tag (SDT) in a Wordprocessing document.
/// This class provides properties for the last saved value and the list of items, enabling advanced customization and management of drop-down list options in SDTs.
/// </summary>
[DataContract]
[XmlRoot("SdtContentDropDownList", Namespace = "DocumentModel.Wordprocessing")]
public partial class SdtContentDropDownList : SdtListItems
{
 /// <summary>
 /// Drop-down list last saved value, specifying the most recently selected option.
 /// </summary>
 public string? LastValue { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}