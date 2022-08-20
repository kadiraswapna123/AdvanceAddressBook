using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAddressBookSystem
{
    internal class UpdateTheContactInfo
    {
        /* A test case that does nothing and succeeds. */
        static void null_test_success(void** state)
        {
            (void)state; /* unused */
        }

        int main(void)
        {
            const struct CMUnitTest tests[] = {
        cmocka_unit_test(null_test_success),
    };
    return cmocka_run_group_tests(tests, NULL, NULL);
}
   
