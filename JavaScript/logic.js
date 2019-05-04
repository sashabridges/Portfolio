// Creating our initial map object
// We set the longitude, latitude, and the starting zoom level
// This gets inserted into the div with an id of 'map'
var myMap = L.map("map", {
  center: [38.8996, -94.7261],
  zoom: 5
});

// Adding a tile layer (the background map image) to our map
// We use the addTo method to add objects to our map
L.tileLayer("https://api.tiles.mapbox.com/v4/{id}/{z}/{x}/{y}.png?access_token={accessToken}", {
  attribution: "Map data &copy; <a href=\"https://www.openstreetmap.org/\">OpenStreetMap</a> contributors, <a href=\"https://creativecommons.org/licenses/by-sa/2.0/\">CC-BY-SA</a>, Imagery © <a href=\"https://www.mapbox.com/\">Mapbox</a>",
  maxZoom: 18,
  id: "mapbox.pirates",
  accessToken: API_KEY
}).addTo(myMap);

var marker = L.marker([38.8996, -94.7261], {
	draggable: false,
	title: "Ku Edwards Campus"
}).addTo(myMap);

marker.bindPopup("You Are Here");

var cities = [
{
	location: [43.8791, -103.4591],
	name: "Mt. Rushmore"
},
{
	location: [36.7245, -98.2104],
	name: "Great Salt Lake, Oklahoma"
},
{
	location: [20.7984, -156.3319],
	name: "Maui",
	population: 144444 
},
{
	location: [41.8781, -87.6298],
	name: "Chicago",
	population: 2720546
},
{
	location: [39.7294, -104.8319],
	name: "Aurora",
	population: 366623
},
{
	location: [36.6437, -93.2185],
	name: "Branson",
	population: 11467 
},
{
	location: [18.4655, -66.1057],
	name: "San Juan"
},
{
	location: [25.7617, -80.1918],
	name: "Miami",
	population: 463347
},
{
	location: [44.8549, -93.2422],
	name: "Mall of America"
},
{
	location: [41.2565, -95.9345],
	name: "Omaha",
	population: 466893
}
];

cities.forEach(city => {
 	L.marker(city.location, {
		draggable: false,
		title: `${city.name}`
	})
	.bindPopup(`<h1>${city.name}</h1><br>${city.population}`)
	.addTo(myMap); 
})