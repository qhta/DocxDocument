namespace DocumentModel.CustomUI;

/// <summary>
/// Defines the TaskSizesType enumeration.
/// Used in types such as TaskFormGroup, TaskGroup.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues))]
public enum TaskSizesType
{
	/// <summary>
	/// Specifies the large medium small Ioption.
	/// </summary>
	[OpenXmlEnumValue("LargeMediumSmall")]
	LargeMediumSmall,
	/// <summary>
	/// Specifies the large medium Ioption.
	/// </summary>
	[OpenXmlEnumValue("LargeMedium")]
	LargeMedium,
	/// <summary>
	/// Specifies the large Ioption.
	/// </summary>
	[OpenXmlEnumValue("Large")]
	Large,
	/// <summary>
	/// Specifies the medium small Ioption.
	/// </summary>
	[OpenXmlEnumValue("MediumSmall")]
	MediumSmall,
	/// <summary>
	/// Specifies the medium Ioption.
	/// </summary>
	[OpenXmlEnumValue("Medium")]
	Medium,
	/// <summary>
	/// Specifies the small Ioption.
	/// </summary>
	[OpenXmlEnumValue("Small")]
	Small
}

