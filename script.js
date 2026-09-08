function tampilkanNama() {
    document.getElementById("namaAnggota").innerHTML =
    `
    <ol
    style="list-style-type: decimal;
    padding-left:5%;">
        <li>mira (mira@gmail.com)</li>
        <li>bella (bella@gmail.com)</li>
    </ol>

    <button onclick="location.reload()">
       tutup kembali
        </button>   
   `;
}

function validasiForm(){
    var tanggal_mulai = document.getElementById('tgl_mulai')
    var tanggal_selesai = document.getElementById('tgl_selesai')

    if(new Data (tanggal_selesai) < new Date (tglMulai)){
        alert('Tanggal Selesai Tidak Boleh Lebih Awal Dari Tanggal Mulai!');
    }
        return true;
}