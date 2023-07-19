#nullable enable
using System;
using System.Collections.Generic;
using System.Diagnostics;

using ModelGenDataConfig;

using Word = Microsoft.Office.Interop.Word;

namespace ExtractReferenceDocumentation
{
  public partial class ThisDocument
  {

    private void ThisDocument_Startup(object sender, System.EventArgs e)
    {
      var docBuilder = new DocXmlBuilder();
      docBuilder.ProcessDocument(this.Application.ActiveDocument);
    }

    private void ThisDocument_Shutdown(object sender, System.EventArgs e)
    {
    }

    #region VSTO Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InternalStartup()
    {
      this.Startup += new System.EventHandler(ThisDocument_Startup);
      this.Shutdown += new System.EventHandler(ThisDocument_Shutdown);
    }

    #endregion
  }
}
