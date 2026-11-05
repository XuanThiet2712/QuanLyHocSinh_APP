# DevExpress WinForms Pivot Grid 

The **DevExpress.Win.PivotGrid** package includes the DevExpress Pivot Grid control for WinForms applications. Use the `PivotGridControl` to summarize, organize, and analyze large volumes of data in an Excel-like cross-tabular layout.

The control allows users to rearrange fields, group and filter data, calculate summaries, drill down to underlying records, apply conditional formatting, and export analysis results.

## Key Features

- **Data Summaries** - Calculates totals and summaries such as Sum, Average, Count, Minimum, and Maximum.
- **Data Shaping** - Supports sorting, grouping, filtering, field reordering, and Top N value analysis.
- **Drill-Down** - Retrieves the source records used to calculate an individual summary value.
- **Conditional Formatting** - Highlights important values with appearance rules, color scales, data bars, and icons.
- **Data Binding** - Connects the Pivot Grid to collections, databases, server-mode sources, Excel files, and OLAP cubes.
- **Layout Persistence** - Saves and restores field positions, sorting, grouping, filtering, and other layout settings.
- **Printing and Export** - Prints Pivot Grid data and exports it to PDF, HTML, MHT, RTF, DOCX, TXT, CSV, XLS, and XLSX formats.

## Examples

Install the **DevExpress.Win.PivotGrid** package:

```
dotnet add package DevExpress.Win.PivotGrid
```

For .NET projects, additionally install the `DevExpress.Win.Design` package.

Add the Pivot Grid control from the Toolbox to a WinForms form.

### Display and Configure a Pivot Grid

The following example assumes that a `PivotGridControl` named `pivotGridControl1` has already been added to a WinForms form.

```csharp
using DevExpress.XtraPivotGrid;
using System.Collections.Generic;
using System.Windows.Forms;

public partial class MainForm : Form {
    public MainForm() {
        InitializeComponent();

        pivotGridControl1.DataSource = new List<Sale> {
            new("Europe", "Beverages", 1200m),
            new("Europe", "Food", 850m),
            new("North America", "Beverages", 1500m),
            new("North America", "Food", 1100m)
        };

        pivotGridControl1.Fields.Add(
            new PivotGridField(nameof(Sale.Region), PivotArea.RowArea));

        pivotGridControl1.Fields.Add(
            new PivotGridField(nameof(Sale.Category), PivotArea.ColumnArea));

        var salesField = new PivotGridField(
            nameof(Sale.Amount),
            PivotArea.DataArea) {
            Caption = "Sales",
            SummaryType = PivotSummaryType.Sum
        };

        pivotGridControl1.Fields.Add(salesField);
    }
}

public record Sale(string Region, string Category, decimal Amount);
```

Users can drag field headers between the row, column, data, and filter areas to change how the Pivot Grid organizes and summarizes data.

### Export Pivot Grid Data to XLSX

The following example exports the current Pivot Grid data and layout to an XLSX file.

```csharp
using DevExpress.XtraPivotGrid;

private void ExportToXlsx(string filePath) {
    var options = new PivotXlsxExportOptions {
        ExportType = DevExpress.Export.ExportType.DataAware
    };

    pivotGridControl1.ExportToXlsx(filePath, options);
}
```

The data-aware export mode creates an editable Excel document and preserves Pivot Grid data-shaping information where supported.

Always validate and normalize file paths obtained from external or untrusted sources before you use them for export.

### Save and Restore the Pivot Grid Layout

The following example saves the Pivot Grid layout to an XML file and restores it later.

```csharp
private void SaveLayout(string filePath) {
    pivotGridControl1.SaveLayoutToXml(filePath);
}

private void RestoreLayout(string filePath) {
    pivotGridControl1.RestoreLayoutFromXml(filePath);
}
```

Assign a unique `Name` to each Pivot Grid field to ensure that field settings are restored correctly.

## Evaluation Period, Pricing Options, and Licensing Terms

Whether you own a license or want to start a 30-day evaluation period, register your DevExpress license key. To obtain your key, log in to the [DevExpress Download Manager](https://www.devexpress.com/ClientCenter/DownloadManager/). Use your existing DevExpress.com account or create a new account for free.

For additional registration instructions, see [License Key for DevExpress Products](https://www.devexpress.com/go/Licensing_Documentation.aspx).

If you purchase a license after evaluating the product, re-register your updated DevExpress license key to remove evaluation version warnings and messages.

This package is included in the following commercial subscriptions:

- [DevExpress WinForms Subscription](https://www.devexpress.com/products/net/controls/winforms/)
- [DevExpress DXperience Subscription](https://www.devexpress.com/subscriptions/dxperience.xml)
- [DevExpress Universal Subscription](https://www.devexpress.com/subscriptions/universal.xml)

See [DevExpress Subscriptions & Licensing](https://www.devexpress.com/buy) for subscription comparison tables, purchasing FAQ, and licensing information. 

## Documentation

- [WinForms Pivot Grid Overview](https://docs.devexpress.com/WindowsForms/3409/controls-and-libraries/pivot-grid)

## Software Bill of Materials (SBOM)

To access SBOM files for DevExpress packages, see [Software Bill of Materials (SBOM) for DevExpress .NET assemblies/NuGet packages, JavaScript, VCL and other redistributable artifacts](https://www.devexpress.com/go/DevExpress_Security_SBOM.aspx).

**See Also**: [Information Security](https://www.devexpress.com/support/information-security.xml) | [Security - What You Need to Know](https://docs.devexpress.com/GeneralInformation/403365/security/security)

## Useful Online Resources

- [www.devexpress.com](https://www.devexpress.com/)
- [DevExpress Support Center](https://www.devexpress.com/Support/Center/)
- [DevExpress Blogs](https://community.devexpress.com/blogs/)
