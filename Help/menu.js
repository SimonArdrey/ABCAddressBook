// Arrays for storing the menu data.
var Menu_text = new Array(0);
var Menu_document = new Array(0);
var contentdir = ""


// This function adds a new menu to the arrays.
function newMenuItem(text, document)
{
    Menu_text.push(text);
    Menu_document.push(document); 
}


// This function builds the menu and outputs it in HTML.
function BuildMenu()
{

    document.write("<table width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" class=\"menu\">");
    document.write("<tr>");
    document.write("<td>");
    document.write("<table cellspacing=\"0\" cellpadding=\"0\" class=\"menu\">");
    document.write("<tr>");

    // Write menu links to the document. 
    for (count = 0; count < Menu_text.length; count++)	// Loop through the menu arrays.
    {
	// Write root menu item.
        document.write("<td class=\"menubutton\"><a href=\"" + Menu_document[count] + "\">" + Menu_text[count] + "</a></td>");
    }    

    document.write("</tr>");
    document.write("</table>");
    document.write("</td>");
    document.write("</tr>");
    document.write("</table>");

}