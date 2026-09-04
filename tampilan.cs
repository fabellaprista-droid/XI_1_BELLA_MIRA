*{
   margin: 0;
   padding: 0;
   box-sizing: border-box;
}

/*membuat tampilan utama navbar*/
.navbar{
    display: flex;
    justify-content: space-between;
    align-items: center;
    background-color: rgb(169, 169, 216);
    color: brown;
    padding: 1rem 2rem;
}

/*membuat tampilan logo*/
.navbar .logo{
    font-size: 2rem;
    font-wight: bold;
}

/*membuat tampilan daftar menu*/ 
.nav-links{
display: flex;
list-style: none;
gap: 25px;
}

/*membuat tampilan teks link*/
.nav-links a{
    color:aliceblue;
    text-decoration: none;
    font-size: 16px;
    font-family:impact;
}

/*membuat tampilan hover*/
.nav-links a:hover{
    background-color: blueviolet;
    color: bisque;
}

#items{
    font-size: 16px;
    font-family: impact;
    color:beige;
}

* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

body {
    font-family: Arial, sans-serif;
    background-color: #f5f0e8;
    color: #333;
}


/* NAVBAR */
nav {
    background-color: #8b5e3c;
    height: 65px;
    display: flex;
    align-items: center;
    justify-content: space-between;
    padding: 0 60px;
}

nav h2 {
    color: white;
}

nav ul {
    display: flex;
    list-style: none;
    gap: 30px;
}

nav ul li a {
    color: white;
    text-decoration: none;
    font-weight: bold;
}

nav ul li a:hover {
    color: #ffe0a3;
}


/* HOME */
.home {
    width: 85%;
    margin: 40px auto;
    display: flex;
    align-items: center;
    gap: 50px;
}

.gambar img {
    width: 350px;
    height: 230px;
    object-fit: cover;
    border-radius: 15px;

    transition: 0.4s;
}


/* HOVER GAMBAR */
.gambar img:hover {
    transform: scale(1.08);
    cursor: pointer;
}

.judul h1 {
    font-size: 40px;
    margin-bottom: 15px;
}

.judul p {
    font-size: 18px;
}


/* RESEP */
.resep {
    width: 85%;
    margin: 30px auto;
    display: flex;
    gap: 40px;
}

.box {
    background-color: white;
    width: 50%;
    padding: 25px;
    border-radius: 15px;
    box-shadow: 0 3px 8px #ccc;
}

.box h2 {
    margin-bottom: 15px;
}

.box ul {
    padding-left: 25px;
}

.box li {
    margin: 8px;
}


/* CARA MEMBUAT */
.cara {
    width: 85%;
    margin: 30px auto;
    background-color: white;
    padding: 25px;
    border-radius: 15px;
    box-shadow: 0 3px 8px #ccc;
}

.cara h2 {
    margin-bottom: 15px;
}

.cara ol {
    padding-left: 25px;
}

.cara li {
    margin: 10px;
}


/* PESAN */
.pesan {
    text-align: center;
    margin: 40px;
}

.pesan button {
    background-color: #c853b1ff;
    color: white;
    border: none;
    padding: 13px 35px;
    border-radius: 8px;
    font-size: 17px;
    cursor: pointer;
}

.pesan button:hover {
    background-color: #dfd6d0ff;
}


