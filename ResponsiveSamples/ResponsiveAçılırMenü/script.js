$(document).ready(function () {
	let links = document.querySelectorAll("nav ul li");
	
	links.forEach(link => {
		link.addEventListener("click",(e) => {
			e.preventDefault();
			[...links].map(link => link.classList.remove("active"));
			link.classList.add("active");
			let target = link.querySelector("a").getAttribute("href").replace("#","");
			document.getElementById(target).scrollIntoView({
				behavior:"smooth",
				block:"start",
				inline:"center"
			})
		})
	})

});

