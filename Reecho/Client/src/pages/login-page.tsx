
import { LoginForm } from "@/components/login-form"

export default function LoginPage() {
    return (
        <div className="flex min-h-svh flex-col items-center justify-center gap-3 bg-muted p-6 md:p-10">
            <div className="flex w-full max-w-sm flex-col gap-3">
                <a href="/" className="flex items-center gap-2 self-center font-bold text-3xl">
                    Reecho
                </a>
                <LoginForm />
            </div>
        </div>
    )
}
