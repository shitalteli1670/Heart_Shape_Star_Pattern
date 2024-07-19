function heart_shape_Print() {
    for (var i = 0; i < 6; i++) {
        var row = "";
        for (var j = 0; j < 7; j++) {
            if ((i === 0 && j % 3 !== 0) ||
                (i === 1 && j % 3 === 0) ||
                (i - j === 2) ||
                (i + j === 8)) {
                row += "* ";
            }
            else {
                row += "  ";
            }
        }
        console.log(row);
    }
}
function main() {
    heart_shape_Print();
}
main();
/* Test Case:

#          * *   * *
#        *     *     *
#        *           *
#          *       *
#            *   *
#              *
*/
