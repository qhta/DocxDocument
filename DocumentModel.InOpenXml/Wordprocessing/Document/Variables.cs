namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a collection of document variables in a WordprocessingML document.
/// This class provides access to and management of <see cref = "Variable"/> objects, enabling advanced storage, retrieval, and organization of custom metadata or automation variables within the document.
/// </summary>
[OpenXmlType(typeof(Variable))]
public class Variables : ModelElementCollection<Variable, DXW.DocumentVariables, DXW.DocumentVariable>
{
}