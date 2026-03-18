namespace DocumentModel.CustomUI;

/// <summary>
/// Defines the TaskSizesType enumeration.
/// Used in types such as TaskFormGroup, TaskGroup.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXO10CUI.TaskSizesValues))]
public enum TaskSizesType
{
	/// <summary>
	/// Specifies the large medium small option.
	/// </summary>
	[OpenXmlEnumValue("LargeMediumSmall")]
	LargeMediumSmall,
	/// <summary>
	/// Specifies the large medium option.
	/// </summary>
	[OpenXmlEnumValue("LargeMedium")]
	LargeMedium,
	/// <summary>
	/// Specifies the large option.
	/// </summary>
	[OpenXmlEnumValue("Large")]
	Large,
	/// <summary>
	/// Specifies the medium small option.
	/// </summary>
	[OpenXmlEnumValue("MediumSmall")]
	MediumSmall,
	/// <summary>
	/// Specifies the medium option.
	/// </summary>
	[OpenXmlEnumValue("Medium")]
	Medium,
	/// <summary>
	/// Specifies the small option.
	/// </summary>
	[OpenXmlEnumValue("Small")]
	Small
}
