namespace DocumentModel;

/// <summary>
/// Represents a container for organizing and arranging controls in the Office Backstage view.
/// Layout containers provide flexible layout capabilities for creating structured, responsive interfaces
/// in the Backstage (the full-screen view accessed via the File tab) with support for nested containers,
/// alignment control, and various child control types.
/// </summary>
/// <remarks>
/// <para>
/// The Backstage view is the full-screen interface that appears when users click the File tab in Office applications,
/// providing access to document management, settings, and other application-level commands. Layout containers
/// are the fundamental building blocks for creating custom Backstage pages and organizing their content.
/// </para>
/// <para>
/// Layout containers provide sophisticated layout capabilities:
/// <list type="bullet">
/// <item><description><b>Flexible arrangement:</b> Control how child elements are positioned (horizontal, vertical, stacked)</description></item>
/// <item><description><b>Alignment control:</b> Specify how content aligns within the container space</description></item>
/// <item><description><b>Expansion behavior:</b> Define how containers grow to fill available space</description></item>
/// <item><description><b>Nested containers:</b> Create complex layouts by nesting containers within containers</description></item>
/// <item><description><b>Responsive design:</b> Containers adapt to different window sizes and display settings</description></item>
/// </list>
/// </para>
/// <para>
/// Layout containers can contain various control types specific to the Backstage view:
/// <list type="bullet">
/// <item><description><b>Input controls:</b> Buttons, checkboxes, edit boxes, dropdown lists, combo boxes</description></item>
/// <item><description><b>Display controls:</b> Labels, images, hyperlinks</description></item>
/// <item><description><b>Grouping controls:</b> Group boxes, radio button groups</description></item>
/// <item><description><b>Nested containers:</b> Other layout containers for complex hierarchies</description></item>
/// </list>
/// </para>
/// <para>
/// Common layout patterns in Backstage customization:
/// <list type="bullet">
/// <item><description><b>Form layouts:</b> Vertical containers with labels and input controls for data entry</description></item>
/// <item><description><b>Button groups:</b> Horizontal containers with multiple action buttons</description></item>
/// <item><description><b>Settings panels:</b> Nested containers organizing related configuration options</description></item>
/// <item><description><b>Info displays:</b> Containers combining images, labels, and hyperlinks for document information</description></item>
/// </list>
/// </para>
/// <para>
/// Layout containers work together with the Backstage tab system to create custom pages accessed via the File tab.
/// They are essential for:
/// <list type="bullet">
/// <item><description>Custom document properties or metadata editors</description></item>
/// <item><description>Application settings and preferences interfaces</description></item>
/// <item><description>Document management workflows (save, export, share)</description></item>
/// <item><description>Information displays (document statistics, permissions, history)</description></item>
/// <item><description>Custom wizards or multi-step processes</description></item>
/// </list>
/// </para>
/// </remarks>
/// <example>
/// <code>
/// // Create a simple vertical form layout
/// var formContainer = new LayoutContainer
/// {
///     Id = "documentPropertiesForm",
///     LayoutChildren = LayoutChildrenKind.Vertical,
///     Align = ExpandKind.Fill,
///     BackstageLabelControl = new BackstageLabelControl
///     {
///         Label = "Document Title:"
///     },
///     BackstageEditBox = new BackstageEditBox
///     {
///         Id = "titleEdit",
///         SizeString = "WWWWWWWWWWWWWWWWWWWW" // Sets width
///     }
/// };
/// 
/// // Create a horizontal button group
/// var buttonGroup = new LayoutContainer
/// {
///     Id = "actionButtons",
///     LayoutChildren = LayoutChildrenKind.Horizontal,
///     Align = ExpandKind.Center,
///     BackstageGroupButton = new BackstageGroupButton
///     {
///         Id = "saveBtn",
///         Label = "Save",
///         ImageMso = "FileSave"
///     }
/// };
/// 
/// // Create a nested container layout
/// var mainContainer = new LayoutContainer
/// {
///     Id = "mainPanel",
///     LayoutChildren = LayoutChildrenKind.Vertical,
///     Expand = ExpandKind.Both,
///     GroupBox = new GroupBox
///     {
///         Id = "settingsGroup",
///         Label = "Settings",
///         // Contains nested child container
///         ChildLayoutContainer = new LayoutContainer
///         {
///             Id = "innerSettings",
///             LayoutChildren = LayoutChildrenKind.Vertical
///         }
///     }
/// };
/// </code>
/// </example>
public interface LayoutContainer
{
  /// <summary>
  /// Gets or sets the unique identifier for this layout container.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The ID is used to uniquely identify this container for programmatic access, callback functions,
  /// and dynamic UI updates. It should be unique within the scope of the Backstage tab or page.
  /// </para>
  /// <para>
  /// Container IDs are important for:
  /// <list type="bullet">
  /// <item><description>Referencing containers in callback functions</description></item>
  /// <item><description>Debugging and troubleshooting layout issues</description></item>
  /// <item><description>Dynamic visibility or enabled state changes</description></item>
  /// <item><description>Maintaining consistent naming across related customizations</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  public string? Id { get; set; }

  /// <summary>
  /// Gets or sets the namespace-qualified identifier for this layout container.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The qualified ID allows containers to be organized into namespaces, preventing naming conflicts
  /// when multiple add-ins or customizations extend the same Backstage area. The format is typically
  /// "namespace:localId" where namespace identifies the add-in or feature group.
  /// </para>
  /// <para>
  /// Qualified IDs are useful in complex scenarios where:
  /// <list type="bullet">
  /// <item><description>Multiple add-ins customize the same Backstage page</description></item>
  /// <item><description>Containers need to be organized by feature or module</description></item>
  /// <item><description>Avoiding ID collisions across different customization components</description></item>
  /// <item><description>Maintaining clear separation between different functional areas</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Example: "MyCompany:DocumentProperties:TitleSection" clearly identifies the container's
  /// ownership and purpose within a larger customization hierarchy.
  /// </para>
  /// </remarks>
  public string? QualifiedId { get; set; }

  /// <summary>
  /// Gets or sets an arbitrary tag value for application-specific purposes.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The tag property provides a flexible way to associate custom metadata with layout containers
  /// for application-specific logic, categorization, or filtering. Unlike the ID properties,
  /// tags are not required to be unique and can be shared across multiple containers.
  /// </para>
  /// <para>
  /// Common uses for tags include:
  /// <list type="bullet">
  /// <item><description><b>Categorization:</b> Group containers by feature, module, or purpose (e.g., "UserSettings", "DocumentInfo")</description></item>
  /// <item><description><b>Behavior flags:</b> Mark containers with special handling requirements (e.g., "RequiresValidation", "ReadOnly")</description></item>
  /// <item><description><b>Data binding:</b> Store keys or references for dynamic data population</description></item>
  /// <item><description><b>Conditional logic:</b> Enable/disable or show/hide groups of related containers</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Tags provide flexibility for custom application logic without interfering with the container's
  /// primary identification and layout properties.
  /// </para>
  /// </remarks>
  public string? Tag { get; set; }

  /// <summary>
  /// Gets or sets how child controls are aligned within the container's layout space.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The Align property controls how child elements are positioned within the container's available space.
  /// This property works in conjunction with <see cref="LayoutChildren"/> to determine the final layout:
  /// <list type="bullet">
  /// <item><description><b>Left/Top:</b> Child controls align to the left edge (horizontal) or top edge (vertical)</description></item>
  /// <item><description><b>Center:</b> Child controls are centered within the available space</description></item>
  /// <item><description><b>Right/Bottom:</b> Child controls align to the right edge (horizontal) or bottom edge (vertical)</description></item>
  /// <item><description><b>Fill:</b> Child controls expand to fill the available space</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Alignment behavior depends on the layout direction:
  /// <list type="bullet">
  /// <item><description>In <b>horizontal layouts:</b> Align affects horizontal positioning (Left, Center, Right)</description></item>
  /// <item><description>In <b>vertical layouts:</b> Align affects vertical positioning (Top, Center, Bottom)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Common alignment patterns:
  /// <list type="bullet">
  /// <item><description><b>Left-aligned labels:</b> Standard form layout with labels aligned to the left</description></item>
  /// <item><description><b>Centered buttons:</b> Action buttons centered in a horizontal container</description></item>
  /// <item><description><b>Fill inputs:</b> Text boxes that expand to use available width</description></item>
  /// <item><description><b>Right-aligned actions:</b> OK/Cancel buttons aligned to the right edge</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  public ExpandKind? Align { get; set; }

  /// <summary>
  /// Gets or sets how the container itself expands to fill available space in its parent.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The Expand property controls how the layout container grows to utilize space within its parent container
  /// or the Backstage page. This is crucial for creating responsive layouts that adapt to different window sizes:
  /// <list type="bullet">
  /// <item><description><b>None:</b> Container maintains its natural size based on content</description></item>
  /// <item><description><b>Horizontal:</b> Container expands to fill available width</description></item>
  /// <item><description><b>Vertical:</b> Container expands to fill available height</description></item>
  /// <item><description><b>Both:</b> Container expands in both directions to fill all available space</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Expansion behavior creates responsive designs that adapt to:
  /// <list type="bullet">
  /// <item><description>Different screen resolutions and display sizes</description></item>
  /// <item><description>Maximized vs. windowed application states</description></item>
  /// <item><description>High-DPI displays with different scaling factors</description></item>
  /// <item><description>Accessibility settings that adjust text and control sizes</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Common expansion patterns:
  /// <list type="bullet">
  /// <item><description><b>Full-page container:</b> Expand=Both for main container that fills the Backstage page</description></item>
  /// <item><description><b>Fixed-height toolbar:</b> Expand=Horizontal for button strips that span the width</description></item>
  /// <item><description><b>Scrollable content:</b> Expand=Vertical for containers that grow with content</description></item>
  /// <item><description><b>Compact widgets:</b> Expand=None for fixed-size information displays</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Understanding the interaction between Expand (container's own sizing) and Align (child control positioning)
  /// is key to creating effective Backstage layouts.
  /// </para>
  /// </remarks>
  public ExpandKind? Expand { get; set; }

  /// <summary>
  /// Gets or sets the layout direction for arranging child controls within the container.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The LayoutChildren property determines the fundamental layout strategy for how child controls
  /// are arranged within the container:
  /// <list type="bullet">
  /// <item><description><b>Horizontal:</b> Child controls are arranged left-to-right in a single row</description></item>
  /// <item><description><b>Vertical:</b> Child controls are stacked top-to-bottom in a single column</description></item>
  /// <item><description><b>None:</b> No automatic layout; manual positioning may be required</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Choosing the appropriate layout direction is fundamental to good Backstage UI design:
  /// <list type="bullet">
  /// <item><description><b>Vertical layouts</b> are ideal for:
  ///   <list type="bullet">
  ///   <item><description>Form-style interfaces with labels and inputs</description></item>
  ///   <item><description>Lists of options or settings</description></item>
  ///   <item><description>Sequential information displays</description></item>
  ///   <item><description>Content that may scroll vertically</description></item>
  ///   </list>
  /// </description></item>
  /// <item><description><b>Horizontal layouts</b> are ideal for:
  ///   <list type="bullet">
  ///   <item><description>Button groups and toolbars</description></item>
  ///   <item><description>Label-input pairs on the same line</description></item>
  ///   <item><description>Side-by-side information panels</description></item>
  ///   <item><description>Navigation or tab-like interfaces</description></item>
  ///   </list>
  /// </description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Layout containers can be nested with different LayoutChildren values to create sophisticated
  /// grid-like layouts. For example, a vertical container can contain multiple horizontal containers
  /// to create a form with multiple controls per row.
  /// </para>
  /// <para>
  /// Example layout hierarchy:
  /// <code>
  /// Container (Vertical)
  ///   ├─ Row1 (Horizontal): [Label] [TextBox]
  ///   ├─ Row2 (Horizontal): [Label] [DropDown]
  ///   └─ Row3 (Horizontal): [Button1] [Button2]
  /// </code>
  /// </para>
  /// </remarks>
  public LayoutChildrenKind? LayoutChildren { get; set; }

  /// <summary>
  /// Gets or sets a button control that is part of a button group in the Backstage view.
  /// </summary>
  /// <remarks>
  /// Backstage group buttons are designed for primary actions in Backstage pages, typically displayed
  /// with large icons and clear labels. They are commonly used for major document operations like
  /// Save, Export, Print, or Share. Group buttons support both image and text labels for maximum clarity.
  /// </remarks>
  public BackstageGroupButton? BackstageGroupButton { get; set; }

  /// <summary>
  /// Gets or sets a checkbox control for boolean options in the Backstage view.
  /// </summary>
  /// <remarks>
  /// Backstage checkboxes provide a simple on/off choice for settings or options. They display
  /// a checkmark when selected and are commonly used in settings pages, preferences, or
  /// document property editors for boolean values.
  /// </remarks>
  public BackstageCheckBox? BackstageCheckBox { get; set; }

  /// <summary>
  /// Gets or sets a text input control for single-line text entry in the Backstage view.
  /// </summary>
  /// <remarks>
  /// Backstage edit boxes provide text input fields for document metadata, file names, paths,
  /// or other string values. They support validation, maximum length constraints, and
  /// can be configured with placeholder text or default values.
  /// </remarks>
  public BackstageEditBox? BackstageEditBox { get; set; }

  /// <summary>
  /// Gets or sets a dropdown list control for selecting from predefined options.
  /// </summary>
  /// <remarks>
  /// Backstage dropdowns display a list of choices when clicked, allowing users to select a single
  /// option from a predefined list. They are ideal for settings with a known set of values,
  /// such as file formats, quality levels, or enumerated options.
  /// </remarks>
  public BackstageDropDown? BackstageDropDown { get; set; }

  /// <summary>
  /// Gets or sets a group of mutually exclusive radio buttons for single-choice selection.
  /// </summary>
  /// <remarks>
  /// Radio groups present multiple options where only one can be selected at a time. They are
  /// appropriate when there are 2-5 related options that are mutually exclusive, such as
  /// page orientation (Portrait/Landscape) or export format options.
  /// </remarks>
  public RadioGroup? RadioGroup { get; set; }

  /// <summary>
  /// Gets or sets a combo box control that combines text input with a dropdown list.
  /// </summary>
  /// <remarks>
  /// Backstage combo boxes allow users to either select from a predefined list or type a custom value.
  /// This provides flexibility when you want to offer common choices while still allowing custom input,
  /// such as for file names with suggested templates or paths with recent locations.
  /// </remarks>
  public BackstageComboBox? BackstageComboBox { get; set; }

  /// <summary>
  /// Gets or sets a hyperlink control for navigation or external links in the Backstage view.
  /// </summary>
  /// <remarks>
  /// Hyperlinks in Backstage pages provide navigation to related content, help documentation,
  /// external websites, or other Backstage pages. They appear in the standard hyperlink style
  /// and can trigger navigation or custom actions when clicked.
  /// </remarks>
  public Hyperlink? Hyperlink { get; set; }

  /// <summary>
  /// Gets or sets a text label control for displaying static text or information.
  /// </summary>
  /// <remarks>
  /// Backstage labels display static text for headings, descriptions, instructions, or data display.
  /// They are essential for form layouts where they identify adjacent input controls, or for
  /// displaying read-only information like document statistics or property values.
  /// </remarks>
  public BackstageLabelControl? BackstageLabelControl { get; set; }

  /// <summary>
  /// Gets or sets a group box that visually groups related controls with an optional border and title.
  /// </summary>
  /// <remarks>
  /// Group boxes provide visual organization by drawing a border around related controls with an
  /// optional title label. They help users understand which settings or options belong together,
  /// improving the readability and organization of complex Backstage pages.
  /// </remarks>
  public GroupBox? GroupBox { get; set; }

  /// <summary>
  /// Gets or sets a nested layout container for creating hierarchical layout structures.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Nested layout containers are essential for creating complex, multi-level layouts in the Backstage view.
  /// By nesting containers with different <see cref="LayoutChildren"/> values, you can create sophisticated
  /// grid-like layouts that would be difficult or impossible with a single container.
  /// </para>
  /// <para>
  /// Common nesting patterns include:
  /// <list type="bullet">
  /// <item><description><b>Form rows:</b> A vertical parent container with horizontal child containers for each form row</description></item>
  /// <item><description><b>Section panels:</b> A horizontal parent with vertical child containers for side-by-side sections</description></item>
  /// <item><description><b>Grouped controls:</b> Containers within group boxes to organize sub-sections</description></item>
  /// <item><description><b>Responsive layouts:</b> Different expansion/alignment settings at each level for adaptive sizing</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Nesting depth should be kept reasonable (typically 3-4 levels maximum) to maintain performance
  /// and avoid overly complex layout hierarchies that are difficult to maintain.
  /// </para>
  /// </remarks>
  public LayoutContainer? ChildLayoutContainer { get; set; }

  /// <summary>
  /// Gets or sets an image control for displaying icons, logos, or decorative images.
  /// </summary>
  /// <remarks>
  /// Image controls in Backstage layouts display static images such as company logos, document preview
  /// thumbnails, icons for visual emphasis, or illustrations for help content. They support various
  /// image sources including embedded resources, Office image MSO identifiers, and custom images.
  /// </remarks>
  public ImageControl? ImageControl { get; set; }
}