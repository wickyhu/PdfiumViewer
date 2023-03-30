# PdfiumViewer

Apache 2.0 License.

## Updated

This is an updated fork of the archived **[pvginkel/PdfiumViewer](https://github.com/pvginkel/PdfiumViewer)** project. 

- Merged all relevant [open pull requests](https://github.com/pvginkel/PdfiumViewer/pulls) of the original repo
- Updated to newer PDFium binaries from https://github.com/bblanchon/pdfium-binaries, tested with nuget package bblanchon.PDFium.Win32 and bblanchon.PDFium.V8.Win32 

## Introduction

PdfiumViewer is a PDF viewer based on the PDFium project.

PdfiumViewer provides a number of components to work with PDF files:

* PdfDocument is the base class used to render PDF documents;

* PdfRenderer is a WinForms control that can render a PdfDocument;

* PdfiumViewer is a WinForms control that hosts a PdfRenderer control and
  adds a toolbar to save the PDF file or print it.

## Bugs

Bugs should be reported through github at
[https://github.com/wickyhu/PdfiumViewer/issues](https://github.com/wickyhu/PdfiumViewer/issues).

## License

PdfiumViewer is licensed under the Apache 2.0 license. See the license details for how PDFium is licensed.
