using Qhta.OpenXmlTools;

namespace DocumentModel.InOpenXml.Test
{
	/// <summary>
	/// Comprehensive test for DocumentModel.DocumentVariables.
	/// </summary>
	public class DocumentVariablesTestClass: _AbstractModelTestClass<DocumentVariables>
  {

		/// <summary>
		/// Creates a sample DocumentVariables object with various property types.
		/// </summary>
		/// <returns>A populated DocumentVariables object.</returns>
		protected override DocumentVariables CreateSampleData()
		{
			var props = new DocumentVariables();
			for (int i=1; i<=10; i++)
			{
				props.Add(new DocumentVariable{ Name = $"Var{i}", Value = $"Value{i}" });
			}
			return props;
		}

		/// <summary>
		/// Updates the specified document with new data variables and returns the updated collection of document variables.
		/// </summary>
		/// <param name="document">The document to update with new data variables.</param>
		/// <param name="data">The collection of data variables to add to the document.</param>
		/// <returns>The updated collection of document variables from the specified document.</returns>
    protected override DocumentVariables UpdateDataInDocument(Document document, DocumentVariables data)
    {
      data.Add(new DocumentVariable { Name = "NewVar", Value = "NewValue" });
			return document.DocumentVariables;
    }

		/// <summary>
		/// Retrieves the Open XML markup for the document variables from the specified WordprocessingML document.	
		/// </summary>
		/// <remarks>This method accesses the document variables stored in the settings part of the main document. If
		/// the document does not contain any document variables, the method returns an empty string.</remarks>
		/// <param name="document">The WordprocessingML document from which to extract the document variables.</param>
		/// <returns>A string containing the Open XML markup of the document variables if present; otherwise, an empty string.</returns>
    protected override string GetOpenXmlFromDocument(Document document)
    {
      return document.WordprocessingDocument!.MainDocumentPart!.DocumentSettingsPart!.Settings!.OuterXml;
    }
  }
}