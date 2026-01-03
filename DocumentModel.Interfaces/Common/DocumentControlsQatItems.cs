namespace DocumentModel;

/// <summary>
/// Represents a collection of custom controls that can be added to the Quick Access Toolbar (QAT)
/// in Office applications at the document level. The QAT is a customizable toolbar that provides
/// quick access to frequently used commands, positioned above or below the ribbon.
/// </summary>
/// <remarks>
/// <para>
/// The Quick Access Toolbar (QAT) is a key feature of the Office ribbon interface, allowing users
/// to personalize their workspace by adding frequently used commands for one-click access. 
/// Document-level QAT customization enables:
/// <list type="bullet">
/// <item><description><b>Document-specific commands:</b> Add custom controls that appear only when a particular document is open</description></item>
/// <item><description><b>Workflow optimization:</b> Provide quick access to document-specific features without navigating the ribbon</description></item>
/// <item><description><b>Template customization:</b> Include specialized commands in document templates</description></item>
/// <item><description><b>User productivity:</b> Reduce clicks and time spent accessing common operations</description></item>
/// </list>
/// </para>
/// <para>
/// Document-level QAT customization differs from application-level QAT customization:
/// <list type="bullet">
/// <item><description><b>Document-level:</b> Controls defined in <see cref="DocumentControlsQatItems"/> appear only when the specific document is open</description></item>
/// <item><description><b>Application-level:</b> Controls persist across all documents and are stored in user settings</description></item>
/// <item><description><b>Priority:</b> Document-level QAT items typically appear alongside or replace application-level customizations</description></item>
/// <item><description><b>Portability:</b> Document-level QAT settings travel with the document file</description></item>
/// </list>
/// </para>
/// <para>
/// The QAT supports a limited set of control types optimized for single-click operations:
/// <list type="bullet">
/// <item><description><b>Cloned controls:</b> References to existing built-in Office commands (recommended for consistency)</description></item>
/// <item><description><b>Custom buttons:</b> Execute custom actions defined by document macros or add-ins</description></item>
/// <item><description><b>Separators:</b> Visually group related commands for better organization</description></item>
/// </list>
/// </para>
/// <para>
/// Unlike the ribbon or context menus, the QAT intentionally has a simplified control model,
/// supporting only basic button controls. Complex controls like galleries, dropdown menus, or
/// toggle buttons are not supported in the QAT to maintain its streamlined, single-click nature.
/// </para>
/// <para>
/// QAT customization is particularly valuable for:
/// <list type="bullet">
/// <item><description>Document templates with specialized workflows (forms, reports, invoices)</description></item>
/// <item><description>Documents that use macros or add-in features extensively</description></item>
/// <item><description>Training environments where standardized command access is needed</description></item>
/// <item><description>Documents requiring frequently repeated operations</description></item>
/// </list>
/// </para>
/// <para>
/// Users can further customize the QAT through the Office UI by right-clicking commands and
/// selecting "Add to Quick Access Toolbar". Document-level QAT items complement rather than
/// restrict these user customizations.
/// </para>
/// </remarks>
/// <example>
/// <code>
/// // Add a custom button to the QAT for a document template
/// var qatItems = new DocumentControlsQatItems
/// {
///     ButtonRegular = new ButtonRegular
///     {
///         Id = "customSaveButton",
///         Label = "Quick Save Template",
///         ImageMso = "FileSaveAs",
///         ScreenTip = "Save this document with template formatting",
///         OnAction = "SaveAsTemplateCallback"
///     }
/// };
/// 
/// // Clone a built-in Office command to the QAT
/// var qatWithClone = new DocumentControlsQatItems
/// {
///     ControlCloneQat = new ControlCloneQat
///     {
///         IdMso = "FormatPainter",
///         Visible = true
///     }
/// };
/// 
/// // Add multiple controls with a separator
/// var qatMultiple = new DocumentControlsQatItems
/// {
///     ControlCloneQat = new ControlCloneQat { IdMso = "Undo" },
///     Separator = new Separator { Id = "sep1" },
///     ButtonRegular = new ButtonRegular
///     {
///         Id = "customExportButton",
///         Label = "Export Data",
///         ImageMso = "ExportExcel"
///     }
/// };
/// </code>
/// </example>
public interface DocumentControlsQatItems : IModelElement
{
  /// <summary>
  /// Gets or sets a reference to a built-in Office control to clone and add to the Quick Access Toolbar.
  /// </summary>
  /// <value>
  /// A <see cref="ControlCloneQat"/> object that specifies which built-in Office command to duplicate in the QAT.
  /// If <see langword="null"/>, no built-in control is cloned.
  /// </value>
  /// <remarks>
  /// <para>
  /// Control cloning is the recommended approach for adding commands to the QAT because it:
  /// <list type="bullet">
  /// <item><description>Maintains consistency with Office's native UI design and behavior</description></item>
  /// <item><description>Automatically inherits the command's icon, tooltip, and keyboard shortcut</description></item>
  /// <item><description>Ensures the command works identically to its ribbon counterpart</description></item>
  /// <item><description>Adapts to Office updates and internationalization automatically</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Common Office commands to clone to the QAT include:
  /// <list type="bullet">
  /// <item><description><b>FileSave:</b> Quick save without dialog</description></item>
  /// <item><description><b>Undo/Redo:</b> Frequently accessed editing commands</description></item>
  /// <item><description><b>FormatPainter:</b> Copy formatting quickly</description></item>
  /// <item><description><b>Print:</b> Direct access to print dialog</description></item>
  /// <item><description><b>SpellingAndGrammar:</b> Quick access to proofing tools</description></item>
  /// <item><description><b>MailMergeStartLetters:</b> For document automation</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The control identifier (idMso) must match a valid Office command ID. Invalid IDs will cause
  /// the control to fail to display. Consult the Office Fluent UI Control Identifiers documentation
  /// for a complete list of available command IDs for each Office application.
  /// </para>
  /// <para>
  /// Cloned controls maintain their enabled/disabled state based on the current document context,
  /// just as they would in the ribbon. For example, the Undo command will be disabled when there's
  /// nothing to undo.
  /// </para>
  /// </remarks>
  public ControlCloneQat? ControlCloneQat { get; set; }

  /// <summary>
  /// Gets or sets a custom button control to add to the Quick Access Toolbar.
  /// </summary>
  /// <value>
  /// A <see cref="ButtonRegular"/> object defining the button's appearance, behavior, and callback.
  /// If <see langword="null"/>, no custom button is added.
  /// </value>
  /// <remarks>
  /// <para>
  /// Custom buttons in the QAT execute document-specific actions through macros or add-in callbacks.
  /// QAT buttons are optimized for immediate, single-click operations and should:
  /// <list type="bullet">
  /// <item><description>Perform well-defined, focused actions (save, export, calculate, format)</description></item>
  /// <item><description>Have clear, concise labels (typically 1-3 words)</description></item>
  /// <item><description>Use recognizable icons for quick visual identification</description></item>
  /// <item><description>Execute quickly without requiring additional user input</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Common use cases for custom QAT buttons in document templates:
  /// <list type="bullet">
  /// <item><description><b>Template-specific save:</b> Save with predefined filename patterns or locations</description></item>
  /// <item><description><b>Data export:</b> Export document data to Excel, database, or other formats</description></item>
  /// <item><description><b>Document validation:</b> Run checks before saving or submitting</description></item>
  /// <item><description><b>Auto-formatting:</b> Apply consistent formatting to selected content</description></item>
  /// <item><description><b>Workflow triggers:</b> Submit for review, request approval, or notify stakeholders</description></item>
  /// <item><description><b>Content insertion:</b> Insert standard boilerplate, signatures, or disclaimers</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Custom QAT buttons require callback implementations in VBA macros (for macro-enabled documents)
  /// or in the host add-in application. The button's <c>onAction</c> attribute specifies the callback
  /// function name that will be invoked when the button is clicked.
  /// </para>
  /// <para>
  /// Design considerations for QAT buttons:
  /// <list type="bullet">
  /// <item><description>Choose icons that clearly represent the action (use imageMso for Office icons when possible)</description></item>
  /// <item><description>Provide screentips (tooltips) that explain what the button does</description></item>
  /// <item><description>Consider button size - QAT buttons are displayed in a compact format</description></item>
  /// <item><description>Test button behavior in different document states (empty, populated, protected)</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  public ButtonRegular? ButtonRegular { get; set; }

  /// <summary>
  /// Gets or sets a visual separator to organize and group related commands in the Quick Access Toolbar.
  /// </summary>
  /// <value>
  /// A <see cref="Separator"/> object representing a vertical dividing line between QAT controls.
  /// If <see langword="null"/>, no separator is added.
  /// </value>
  /// <remarks>
  /// <para>
  /// Separators in the QAT are vertical lines that visually divide commands into logical groups,
  /// improving organization and scannability. Unlike separators in menus or the ribbon, QAT separators
  /// are typically more subtle due to the compact nature of the toolbar.
  /// </para>
  /// <para>
  /// Best practices for using QAT separators:
  /// <list type="bullet">
  /// <item><description><b>Group related commands:</b> Separate file operations from editing operations from formatting operations</description></item>
  /// <item><description><b>Distinguish custom from built-in:</b> Use separators to show where document-specific commands begin</description></item>
  /// <item><description><b>Use sparingly:</b> Too many separators can make the QAT appear cluttered</description></item>
  /// <item><description><b>Maintain consistency:</b> Use similar grouping patterns across related documents or templates</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Example QAT organization patterns:
  /// <list type="bullet">
  /// <item><description>[Save] [Undo] [Redo] | [Custom Format] [Custom Export]</description></item>
  /// <item><description>[Print] | [Template Action 1] [Template Action 2] | [User Commands...]</description></item>
  /// <item><description>[File Operations] | [Edit Operations] | [Document-Specific Tools]</description></item>
  /// </list>
  /// Where "|" represents a separator.
  /// </para>
  /// <para>
  /// Separators help users quickly distinguish between different categories of commands, especially
  /// important when mixing built-in Office commands with custom document-specific buttons.
  /// They provide visual breathing room and make the QAT easier to scan at a glance.
  /// </para>
  /// </remarks>
  public Separator? Separator { get; set; }
}