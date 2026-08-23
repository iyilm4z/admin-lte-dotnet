const fs = require("fs");
const path = require("path");

function copyFile(src, dest) {
    fs.mkdirSync(path.dirname(dest), { recursive: true });
    fs.copyFileSync(src, dest);
    console.log("✔ Copied:", dest);
}

function copyFolder(srcDir, destDir) {
    fs.mkdirSync(destDir, { recursive: true });

    fs.readdirSync(srcDir).forEach((file) => {
        const srcPath = path.join(srcDir, file);
        const destPath = path.join(destDir, file);

        if (fs.lstatSync(srcPath).isDirectory()) {
            copyFolder(srcPath, destPath);
        } else {
            copyFile(srcPath, destPath);
        }
    });
}

/* ============================
   COPY LIBRARIES
============================ */

console.log("📦 Copying libraries into wwwroot/lib ...");

// jQuery
copyFile(
    "node_modules/jquery/dist/jquery.min.js",
    "wwwroot/lib/jquery/jquery.min.js"
);

// Bootstrap bundle
copyFile(
    "node_modules/bootstrap/dist/js/bootstrap.bundle.min.js",
    "wwwroot/lib/bootstrap/bootstrap.bundle.min.js"
);

// FontAwesome
copyFile(
    "node_modules/@fortawesome/fontawesome-free/css/all.min.css",
    "wwwroot/lib/font-awesome/css/all.min.css"
);

copyFolder(
    "node_modules/@fortawesome/fontawesome-free/webfonts",
    "wwwroot/lib/font-awesome/webfonts"
);

// AdminLTE
copyFile(
    "node_modules/admin-lte/dist/js/adminlte.min.js",
    "wwwroot/lib/admin-lte/js/adminlte.min.js"
);

copyFile(
    "node_modules/admin-lte/dist/css/adminlte.min.css",
    "wwwroot/lib/admin-lte/css/adminlte.min.css"
);

copyFolder(
    "node_modules/admin-lte/dist/img",
    "wwwroot/lib/admin-lte/img"
);

console.log("✅ All libraries copied successfully!");
