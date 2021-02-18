import { ActivatedRoute, Router } from "@angular/router";

export class utils {
urlArgs() {
    var query = window.location.search.substring(1); // Get query string, minus '?'
    var pairs = query.split("&"); // Split at ampersands
    if (window.location.search){
        console.log( " window.location.search " +  window.location.search);            
        var args = {}; // Start with an empty object
        pairs.forEach(element => {
            var pos = element.indexOf('='); // Look for "name=value"
            var name = element.substring(0,pos); // Extract the name
            var value = element.substring(pos+1); // Extract the value
            value = decodeURIComponent(value); // Decode the value
            args[name] = value; // Store as a property
        });
    return args; // Return the parsed arguments
    }
    return null;
}
args2Url(params){
    let ulrQuery = "?";
    Object.keys(params).forEach(element => {
        ulrQuery += element + "=" + params[element] + "&";// element + "=" +  
        //ulrQuery += element. + "/";// element + "=" +  
    });
    console.log(ulrQuery);
    return ulrQuery;
    }
hasArgs(){
    let params = this.urlArgs();
    return (params && Object.keys(params).length > 0)
}
} 