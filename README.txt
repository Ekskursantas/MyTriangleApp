TEST CASES

TRIANGLIE SIDE INPUT:

INPUT      EXPECTED        STATE
5,5,5      EQULATERAL      VALID
1,2,3      NOT A TRIANGLE  INVALID
5,5,9      ISOSCELES       VALID
5,5,11     NOT A TRIANGLE  INVALID
5,9,10     SCALENE         VALID
0,0,0      NOT A TRIANGLE  INVALID
-1,-1,-1   NOT A TRIANGLE  INVALID
S          NOT A NUMBER    INVALID
@          NOT A NUMBER    INVALID
" "        NOT A NUMBER    INVALID
""         NOT A NUMBER    INVALID

AFTER ANSWER PRINTED:

INPUT      EXPECTED             STATE
Y          INPUT NEW VALUES     VALID
y          INPUT NEW VALUES     VALID
""         EXIT                 VALID
" "        EXIT                 VALID
@          EXIT                 VALID
S          EXIT                 VALID
s          EXIT                 VALID
-10        EXIT                 VALID
